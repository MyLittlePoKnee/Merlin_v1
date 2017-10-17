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
    /* Internal type: e7 */
    public partial class FurnitureItemDescriptor : DurableItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private e7 _internal;
        
        #region Properties
        
        public e7 FurnitureItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureItemDescriptor(e7 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator e7(FurnitureItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureItemDescriptor(e7 instance)
        {
            return new FurnitureItemDescriptor(instance);
        }
        
        public static implicit operator bool(FurnitureItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
