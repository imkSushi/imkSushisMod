using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class StylistSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Stylist;
        public override bool CanSpawn(Player player)
        {
            return true;
        }

        public override void OnSummoning()
        {
            NPC.savedStylist = true;
        }
    }
}