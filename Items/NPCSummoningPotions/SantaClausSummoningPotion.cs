using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class SantaClausSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.SantaClaus;
        public override bool CanSpawn(Player player)
        {
            return NPC.downedFrost && Main.xMas;
        }
    }
}