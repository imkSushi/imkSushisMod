using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class TimeSphere : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 24;

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
	      DisplayName.SetDefault("Time Sphere");
	      Tooltip.SetDefault("Moves time forward by six Terrarian hours");
	    }

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
			ModContent.GetInstance<imkSushisWorld>().AddTime(216);
			return base.ConsumeItem(player);
		}
	}
}
