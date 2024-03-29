using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class SteampunkerSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Steampunker;
        public override bool CanSpawn(Player player)
        {
            return NPC.downedMechBossAny;
        }
    }
}