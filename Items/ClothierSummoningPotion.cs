using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class ClothierSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Clothier;

        public override bool CanSpawn(Player player)
        {
            return NPC.downedBoss3;
        }
    }
}