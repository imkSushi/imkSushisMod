using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items.NPCSummoningPotions
{
	public class ArmsDealerSummoningPotion : NPCSummoningPotion
	{
		public override int NpcId => NPCID.ArmsDealer;
		public override bool CanSpawn(Player player)
		{
			return true;
		}
	}
}