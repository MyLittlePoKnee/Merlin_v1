////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.357.113485-prod
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

namespace Albion_Direct
{
    /* Internal type: axl */
    public partial class FurnitureItemObject : DurableItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private axl _internal;
        
        #region Properties
        
        public axl FurnitureItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureItemObject(axl instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator axl(FurnitureItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureItemObject(axl instance)
        {
            return new FurnitureItemObject(instance);
        }
        
        public static implicit operator bool(FurnitureItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
