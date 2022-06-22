using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class MeteoritePotion : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.IronskinPotion);

			Item.width = 18;
			Item.height = 30;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 45;
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 30;
			Item.healLife = 0;
			Item.buffType = 0;
			Item.buffTime = -1;

		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Meteorite Potion");
	      Tooltip.SetDefault("So that's what happened to the dinosaurs...");
	    }

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
			WorldGen.dropMeteor();
			return base.ConsumeItem(player);
		}
	}
}
