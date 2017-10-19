﻿using Merlin.API.Direct;
using Merlin.Pathing;
using Merlin.Pathing.Worldmap;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using YinYang.CodeProject.Projects.SimplePathfinding.PathFinders.AStar;

namespace Merlin.Profiles.Gatherer
{
    public sealed partial class Gatherer
    {
        private WorldPathingRequest _worldPathingRequest;
        private ClusterPathingRequest _bankPathingRequest;
        private PositionPathingRequest _bankFindPathingRequest;
        private bool _isDepositing;

        public void Bank()
        {
            var player = _localPlayerCharacterView.GetLocalPlayerCharacter();
            if (player == null) Core.Log("player == NULL");

            if (!HandleMounting(Vector3.zero))
                return;

            if (!_isDepositing && _localPlayerCharacterView.GetLoadPercent() <= _percentageForBanking)
            {
                Core.Log("[Restart]");
                _state.Fire(Trigger.Restart);
                return;
            }
            
            if (HandlePathing(ref _worldPathingRequest))
                return;

            if (HandlePathing(ref _bankFindPathingRequest, () => _client.GetEntities<BankBuildingView>((x) => { return true; }).Count > 0))
                return;

            if (HandlePathing(ref _bankPathingRequest, null, () => _reachedPointInBetween = true))
                return;

            Worldmap worldmapInstance = GameGui.Instance.WorldMap;
            if (worldmapInstance == null) Core.Log("worldmapInstance == NULL");

            Vector3 playerCenter = _localPlayerCharacterView.transform.position;
            if (playerCenter == null) Core.Log("playerCenter == NULL");
            ClusterDescriptor currentWorldCluster = _world.GetCurrentCluster();
            if(currentWorldCluster == null) Core.Log("CurrentWorldClust == NULL");
            ClusterDescriptor townCluster = worldmapInstance.GetCluster(TownClusterNames[_selectedTownClusterIndex]).Info;
            if (townCluster == null) Core.Log("townCluster == NULL");
            //ClusterDescriptor bankCluster = townCluster.GetExits().Find(e => e.GetDestination().GetName().Contains("Bank")).GetDestination();
            //if (bankCluster == null) Core.Log("bankCluster == NULL");

            if (currentWorldCluster.GetName() == townCluster.GetName())
            {
                var banks = _client.GetEntities<BankBuildingView>((x) => { return true; });
                if (banks == null) Core.Log("banks == NULL");

                if (banks.Count == 0)
                    return;

                _currentTarget = banks.First();
                if (_localPlayerCharacterView.TryFindPath(new ClusterPathfinder(), _currentTarget, IsBlockedWithExitCheck, out List<Vector3> pathing))
                {
                    _bankPathingRequest = new ClusterPathingRequest(_localPlayerCharacterView, _currentTarget, pathing);
                    return;
                }

                if (_currentTarget is BankBuildingView resource)
                {
                    if (!GameGui.Instance.BankBuildingVaultGui.gameObject.activeInHierarchy)
                    {
                        _localPlayerCharacterView.Interact(resource);
                        return;
                    }

                    //Get inventory
                    var playerStorage = GameGui.Instance.CharacterInfoGui.InventoryItemStorage;
                    var vaultStorage = GameGui.Instance.BankBuildingVaultGui.BankVault.InventoryStorage;

                    var ToDeposit = new List<UIItemSlot>();

                    //Get all items we need
                    var resourceTypes = Enum.GetNames(typeof(ResourceType)).Select(r => r.ToLowerInvariant()).ToArray();
                    foreach (var slot in playerStorage.ItemsSlotsRegistered)
                        if (slot != null && slot.ObservedItemView != null)
                        {
                            var slotItemName = slot.ObservedItemView.name.ToLowerInvariant();
                            if(!slotItemName.Contains("journalitem"))
                                if (resourceTypes.Any(r => slotItemName.Contains(r)))
                                    ToDeposit.Add(slot);
                            if (slotItemName.Contains("journalitem") && slotItemName.Contains("full"))
                                ToDeposit.Add(slot);
                        }

                    _isDepositing = ToDeposit != null && ToDeposit.Count > 0;
                    foreach (var item in ToDeposit)
                    {
                        GameGui.Instance.MoveItemToItemContainer(item, vaultStorage.ItemContainerProxy);
                    }

                    if (_isDepositing)
                        return;
                    else
                    {
                        Core.Log("[Bank Done]");
                        _state.Fire(Trigger.BankDone);
                    }
                }
            }
            else
            {
                var pathfinder = new WorldmapPathfinder();
                if (pathfinder.TryFindPath(currentWorldCluster, townCluster, StopClusterFunction, out var path, out var pivots))
                    _worldPathingRequest = new WorldPathingRequest(currentWorldCluster, townCluster, path, _skipUnrestrictedPvPZones);
            }
        }
    }
}