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
    /* Internal type: bb5 */
    public partial class GuiSimpleItemProxy : GuiItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private bb5 _internal;
        
        #region Properties
        
        public bb5 GuiSimpleItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiSimpleItemProxy(bb5 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GuiSimpleItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator bb5(GuiSimpleItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiSimpleItemProxy(bb5 instance)
        {
            return new GuiSimpleItemProxy(instance);
        }
        
        public static implicit operator bool(GuiSimpleItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
