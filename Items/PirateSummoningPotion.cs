using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class PirateSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Pirate;
        public override bool CanSpawn(Player player)
        {
            return NPC.downedPirates;
        }
    }
}