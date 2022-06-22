using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class NurseSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Nurse;

        public override bool CanSpawn(Player player)
        {
            return player.statLifeMax > 100;
        }
    }
}