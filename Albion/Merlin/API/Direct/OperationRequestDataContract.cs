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
    /* Internal type: kh */
    public partial class OperationRequestDataContract
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private kh _internal;
        
        #region Properties
        
        public kh OperationRequestDataContract_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public OperationRequestDataContract(kh instance)
        {
            _internal = instance;
        }
        
        static OperationRequestDataContract()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator kh(OperationRequestDataContract instance)
        {
            return instance._internal;
        }
        
        public static implicit operator OperationRequestDataContract(kh instance)
        {
            return new OperationRequestDataContract(instance);
        }
        
        public static implicit operator bool(OperationRequestDataContract instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
