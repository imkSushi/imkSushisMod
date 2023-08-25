using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
	public class AnglerSummoningPotion : NPCSummoningPotion
	{
		public override int NpcId => NPCID.Angler;

		public override void OnSummoning()
		{
			NPC.savedAngler = true;
		}

		public override bool CanSpawn(Player player)
		{
			return true;
		}
	}
}