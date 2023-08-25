using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
    public class PainterSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Painter;
        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}