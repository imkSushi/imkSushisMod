using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class DryadSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Dryad;

        public override bool CanSpawn(Player player)
        {
            return NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3;
        }
    }
}