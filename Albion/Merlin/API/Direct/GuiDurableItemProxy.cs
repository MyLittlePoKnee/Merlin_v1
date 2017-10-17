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
    /* Internal type: a7j */
    public partial class GuiDurableItemProxy : GuiItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a7j _internal;
        
        #region Properties
        
        public a7j GuiDurableItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public Number GetUnfloatyFloat() => _internal.ba();
        
        #endregion
        
        #region Constructor
        
        public GuiDurableItemProxy(a7j instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GuiDurableItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a7j(GuiDurableItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiDurableItemProxy(a7j instance)
        {
            return new GuiDurableItemProxy(instance);
        }
        
        public static implicit operator bool(GuiDurableItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
