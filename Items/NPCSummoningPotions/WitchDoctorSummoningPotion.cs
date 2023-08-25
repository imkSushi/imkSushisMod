using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class WitchDoctorSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.WitchDoctor;
        public override bool CanSpawn(Player player)
        {
            return NPC.downedQueenBee;
        }
    }
}