﻿namespace Merlin.API.Direct
{
    public partial class HarvestableObject
    {
        public bool CanLoot(LocalPlayerCharacterView localPlayer)
        {
            /*if (IsHarvestable()) //Returns true, when monster loot is not Harvestable by local player
            {
                return false;
            }*/

            bool requiresTool = RequiresTool();
            EquipmentItemProxy tool = GetTool(localPlayer);

            if (requiresTool && !tool)
                return false;

            //TODO: Implement converters
            DurableItemStackProxy toolProxy = Utilities.GetStackProxy(tool).ItemStackProxy_Internal as a39;

            int durability = toolProxy ? Utilities.SomeCalculationWithUnfloatyFloats(tool.GetUnfloatyFloat(), toolProxy.GetUnfloatyFloat()) : -1;

            if (requiresTool && durability <= 10)
                return false;

            return true;
        }

        public EquipmentItemProxy GetTool(LocalPlayerCharacterView player)
        {
            return GetTool(player.GetLocalPlayerCharacter(), true);
        }

        public bool RequiresTool()
        {
            return GetTierDescriptor().RequiresTool();
        }
    }
}