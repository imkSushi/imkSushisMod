using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class BiomeKey : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 22;
			Item.rare = ItemRarityID.Blue;
			Item.value = 50000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Biome Key");
			Tooltip.SetDefault("Generic Corn Flakes\nTransfer from one biome key to another through this");
		}
	}
}