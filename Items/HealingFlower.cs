using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using imkSushisMod;

namespace imkSushisMod.Items
{
	public class HealingFlower : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 44;

			Item.rare = ItemRarityID.Blue;
			Item.value = 10000;
			Item.accessory = true;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Healing Flower");
      Tooltip.SetDefault("This automatically Quick Heals when neccessary");
    }


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<imkSushisPlayer>().HighestHealth();
		}
	}
}
