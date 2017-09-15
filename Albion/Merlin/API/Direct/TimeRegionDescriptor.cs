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
    /* Internal type: l4 */
    public partial class TimeRegionDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private l4 _internal;
        
        #region Properties
        
        public l4 TimeRegionDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TimeRegionDescriptor(l4 instance)
        {
            _internal = instance;
        }
        
        static TimeRegionDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator l4(TimeRegionDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TimeRegionDescriptor(l4 instance)
        {
            return new TimeRegionDescriptor(instance);
        }
        
        public static implicit operator bool(TimeRegionDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
