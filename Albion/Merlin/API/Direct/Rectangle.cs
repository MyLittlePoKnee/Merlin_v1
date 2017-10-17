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
    /* Internal type: afi */
    public partial struct Rectangle
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private afi _internal;
        
        #region Properties
        
        public afi Rectangle_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Rectangle(afi instance)
        {
            _internal = instance;
        }
        
        static Rectangle()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator afi(Rectangle instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Rectangle(afi instance)
        {
            return new Rectangle(instance);
        }
        #endregion
    }
}
