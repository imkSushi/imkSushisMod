using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class WizardSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Wizard;
        public override bool CanSpawn(Player player)
        {
            return Main.hardMode;
        }

        public override void OnSummoning()
        {
            NPC.savedWizard = true;
        }
    }
}