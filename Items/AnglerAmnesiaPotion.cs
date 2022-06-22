using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class AnglerAmnesiaPotion : ModItem
	{
		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.width = 18;
			Item.height = 30;
			Item.consumable = true;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 30;
			Item.UseSound = SoundID.Item3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angler Amnesia Potion");
			Tooltip.SetDefault("Sorry, what was I going to write here?");
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.AnyNPCs(NPCID.Angler);
		}

		public override bool? UseItem(Player player)
		{
			Main.anglerQuestFinished = false;
			var oldId = Main.anglerQuest;
			while (Main.anglerQuest == oldId)
			{
				Main.AnglerQuestSwap();
			}
			return true;
		}
	}
}