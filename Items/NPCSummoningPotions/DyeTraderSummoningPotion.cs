using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class DyeTraderSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.DyeTrader;

        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}