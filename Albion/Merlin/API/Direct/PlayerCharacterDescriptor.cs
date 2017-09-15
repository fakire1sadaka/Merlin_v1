////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.97446-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: ad4 */
    public partial class PlayerCharacterDescriptor : CharacterDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ad4 _internal;
        
        #region Properties
        
        public ad4 PlayerCharacterDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetHarvestRange() => _internal.du();
        public int GetInventorySize() => _internal.dt();
        public float GetUseObjectRange() => _internal.dv();
        
        #endregion
        
        #region Constructor
        
        public PlayerCharacterDescriptor(ad4 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static PlayerCharacterDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ad4(PlayerCharacterDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PlayerCharacterDescriptor(ad4 instance)
        {
            return new PlayerCharacterDescriptor(instance);
        }
        
        public static implicit operator bool(PlayerCharacterDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
