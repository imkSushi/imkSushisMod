using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class MerchantSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Merchant;

        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}