using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class ZoologistSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.BestiaryGirl;
        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}