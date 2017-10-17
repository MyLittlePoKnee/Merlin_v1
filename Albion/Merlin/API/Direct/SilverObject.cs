////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
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
    /* Internal type: a26 */
    public partial class SilverObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a26 _internal;
        
        #region Properties
        
        public a26 SilverObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SilverObject(a26 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SilverObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a26(SilverObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SilverObject(a26 instance)
        {
            return new SilverObject(instance);
        }
        
        public static implicit operator bool(SilverObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
