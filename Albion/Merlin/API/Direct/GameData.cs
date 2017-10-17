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
    /* Internal type: hn */
    public partial class GameData
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private hn _internal;
        
        #region Properties
        
        public hn GameData_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public AgentsDataFile GetAgents() => _internal.a3();
        public BuildingDataFile GetBuildings() => _internal.aq();
        public GameDataFile GetGameData() => _internal.@as();
        public ItemsDataFile GetItems() => _internal.ao();
        public MobCharactersDataFile GetMobCharacters() => _internal.at();
        public PlayerCharactersDataFile GetPlayerCharacters() => _internal.av();
        public SpellsDataFile GetSpells() => _internal.ap();
        public WorldDataFile GetWorld() => _internal.ay();
        
        #endregion
        
        #region Constructor
        
        public GameData(hn instance)
        {
            _internal = instance;
        }
        
        static GameData()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hn(GameData instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GameData(hn instance)
        {
            return new GameData(instance);
        }
        
        public static implicit operator bool(GameData instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
