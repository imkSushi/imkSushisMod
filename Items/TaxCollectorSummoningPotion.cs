using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class TaxCollectorSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.TaxCollector;
        public override bool CanSpawn(Player player)
        {
            return Main.hardMode;
        }

        public override void OnSummoning()
        {
            NPC.savedTaxCollector = true;
        }
    }
}