using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class BaseSummoningPotion : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 30;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
		}


		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Base Summoning Potion");
			Tooltip.SetDefault("Genie not included\nUsed to make other NPC summoning potions");
		}

		public override bool CanUseItem(Player player)
		{
			return false;
		}
	}
}