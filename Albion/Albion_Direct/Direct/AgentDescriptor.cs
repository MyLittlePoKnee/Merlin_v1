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
    /* Internal type: aov */
    public partial class AgentDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aov _internal;
        
        #region Properties
        
        public aov AgentDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public AgentDescriptor(aov instance)
        {
            _internal = instance;
        }
        
        static AgentDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aov(AgentDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator AgentDescriptor(aov instance)
        {
            return new AgentDescriptor(instance);
        }
        
        public static implicit operator bool(AgentDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
