using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class GreaterTimeSphere : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 32;

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

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Greater Time Sphere");
	      Tooltip.SetDefault("Moves time forward by twelve Terrarian hours");
	    }

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
			ModContent.GetInstance<imkSushisWorld>().AddTime(432);
			return true;
		}
	}
}
