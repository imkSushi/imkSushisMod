using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class GoblinTinkererSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.GoblinTinkerer;

        public override void OnSummoning()
        {
            NPC.savedGoblin = true;
        }

        public override bool CanSpawn(Player player)
        {
            return NPC.downedGoblins;
        }
    }
}