using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class CyborgSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Cyborg;

        public override bool CanSpawn(Player player)
        {
            return NPC.downedPlantBoss;
        }
    }
}