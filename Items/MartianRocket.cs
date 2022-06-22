using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class MartianRocket : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 30;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Martian Rocket");
	      Tooltip.SetDefault("I thought it took longer than a tick to get to Mars?");
	    }

		public override bool CanUseItem(Player player)
		{
			return Main.CanStartInvasion(4,true);
		}

		public override bool? UseItem(Player player)
		{
			Main.StartInvasion(InvasionID.MartianMadness);
			return true;
		}
	}
}
