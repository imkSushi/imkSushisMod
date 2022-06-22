using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class PrincessSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Princess;
        public override bool CanSpawn(Player player)
        {
            return NPC.downedBoss1 && NPC.downedBoss2 && NPC.downedBoss3 && Main.hardMode && NPC.downedQueenBee && NPC.downedPlantBoss && NPC.downedMechBossAny && NPC.downedGoblins && NPC.downedPirates;
        }
    }
}