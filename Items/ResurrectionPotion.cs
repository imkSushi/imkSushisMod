using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class ResurrectionPotion : ModItem
	{
		public override void SetDefaults()
		{
			Item.potion = true;

			Item.width = 26;
			Item.height = 32;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 45;
			Item.rare = ItemRarityID.Blue;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.maxStack = 30;

		}

		public override bool CanUseItem(Player player)
		{
			return player.showLastDeath;
		}

		public override bool? UseItem(Player player)
		{
			var deathPoint = new Vector2 (player.lastDeathPostion.X - 16, player.lastDeathPostion.Y - 24);
			player.Teleport(deathPoint);
			return true;
		}
	}
}
