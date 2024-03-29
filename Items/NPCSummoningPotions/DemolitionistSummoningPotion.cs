using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class DemolitionistSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Demolitionist;

        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}