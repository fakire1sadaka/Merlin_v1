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
    /* Internal type: akg */
    public partial class ClusterDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private akg _internal;
        
        #region Properties
        
        public akg ClusterDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public AgentDescriptor GetAgent(Guid A_0) => _internal.ak((Guid)A_0);
        public List<AgentDescriptor> GetAgents() => _internal.a6().Select(x =>(AgentDescriptor)x).ToList();
        public Point2 GetCenter() => _internal.bk();
        public ClusterTypeDescriptor GetClusterType() => _internal.aq();
        public List<ClusterExitDescriptor> GetExits() => _internal.a1().Select(x =>(ClusterExitDescriptor)x).ToList();
        public string GetIdent() => _internal.ak();
        public Point2 GetOrigin() => _internal.aw();
        public Point2 GetSize() => _internal.ax();
        public List<TerritoryDescriptor> GetTerritories() => _internal.a4().Select(x =>(TerritoryDescriptor)x).ToList();
        public TerritoryDescriptor GetTerritory(Guid A_0) => _internal.al((Guid)A_0);
        public string GetName() => _internal.an();
        
        #endregion
        
        #region Constructor
        
        public ClusterDescriptor(akg instance)
        {
            _internal = instance;
        }
        
        static ClusterDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator akg(ClusterDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterDescriptor(akg instance)
        {
            return new ClusterDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
