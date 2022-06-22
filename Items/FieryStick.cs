using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class FieryStick : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 60;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = false;
			Item.maxStack = 30;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Fiery Stick");
	      Tooltip.SetDefault("Wait, but it's only Wave 1...");
	    }

		public override bool CanUseItem(Player player)
		{
			return Main.pumpkinMoon;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.MourningWood);
			return true;
		}
	}
}
