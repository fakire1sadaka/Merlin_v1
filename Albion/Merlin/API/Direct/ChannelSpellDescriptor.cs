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
    /* Internal type: g1 */
    public partial class ChannelSpellDescriptor : ActiveSpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private g1 _internal;
        
        #region Properties
        
        public g1 ChannelSpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ChannelSpellDescriptor(g1 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ChannelSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator g1(ChannelSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ChannelSpellDescriptor(g1 instance)
        {
            return new ChannelSpellDescriptor(instance);
        }
        
        public static implicit operator bool(ChannelSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
