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
    /* Internal type: hv */
    public partial class HarvestableDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private hv _internal;
        
        #region Properties
        
        public hv HarvestableDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public HarvestableTierDescriptor[] GetTiers() => _internal.i().Select(x =>(HarvestableTierDescriptor)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public HarvestableDescriptor(hv instance)
        {
            _internal = instance;
        }
        
        static HarvestableDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hv(HarvestableDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableDescriptor(hv instance)
        {
            return new HarvestableDescriptor(instance);
        }
        
        public static implicit operator bool(HarvestableDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
