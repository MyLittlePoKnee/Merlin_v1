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
    /* Internal type: by */
    public partial class DurableItemDescriptor : ItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private by _internal;
        
        #region Properties
        
        public by DurableItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public DurableItemDescriptor(by instance) : base(instance)
        {
            _internal = instance;
        }
        
        static DurableItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator by(DurableItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator DurableItemDescriptor(by instance)
        {
            return new DurableItemDescriptor(instance);
        }
        
        public static implicit operator bool(DurableItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
