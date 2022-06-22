using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class PartyGirlSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.PartyGirl;
        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}