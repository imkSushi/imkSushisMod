using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class LesserTimeSphere : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 20;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 45;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = false;
			Item.maxStack = 30;
			Item.value = 100000;
		}

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
			ModContent.GetInstance<imkSushisWorld>().AddTime(36);
			return true;
		}
	}
}
