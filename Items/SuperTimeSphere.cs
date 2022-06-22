using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class SuperTimeSphere : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 36;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 20;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = false;
			Item.maxStack = 45;
			Item.value = 100000;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Super Time Sphere");
	      Tooltip.SetDefault("Moves time forward by twenty Terrarian hours");
	    }

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
			ModContent.GetInstance<imkSushisWorld>().AddTime(720);
			return true;
		}
	}
}
