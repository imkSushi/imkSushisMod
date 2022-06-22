using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class GolferSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Golfer;

        public override bool CanSpawn(Player player)
        {
            return true;
        }

        public override void OnSummoning()
        {
            NPC.savedGolfer = true;
        }
    }
}