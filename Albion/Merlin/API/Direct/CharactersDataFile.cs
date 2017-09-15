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
    /* Internal type: df */
    public partial class CharactersDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private df _internal;
        
        #region Properties
        
        public df CharactersDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public CharactersDataFile(df instance) : base(instance)
        {
            _internal = instance;
        }
        
        static CharactersDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator df(CharactersDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator CharactersDataFile(df instance)
        {
            return new CharactersDataFile(instance);
        }
        
        public static implicit operator bool(CharactersDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
