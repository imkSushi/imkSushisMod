using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class MechanicSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Mechanic;

        public override void OnSummoning()
        {
            NPC.savedMech = true;
        }

        public override bool CanSpawn(Player player)
        {
            return NPC.downedBoss3;
        }
    }
}