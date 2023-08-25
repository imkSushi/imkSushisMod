using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class BartenderSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.DD2Bartender;

        public override void OnSummoning()
        {
            NPC.savedBartender = true;
        }

        public override bool CanSpawn(Player player)
        {
            return NPC.downedBoss2;
        }
    }
}