using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class BloodOrb : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
			Item.value = 50000;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Blood Orb");
	      Tooltip.SetDefault("Stop dribbling!");
	    }

		public override bool CanUseItem(Player player)
		{
			return (Main.pumpkinMoon == false) && (Main.snowMoon == false) && (Main.bloodMoon == false) && (Main.dayTime == false);
		}

		public override bool? UseItem(Player player)
		{
			Main.bloodMoon = true;
			return true;
		}
	}
}
