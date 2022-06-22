using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class Cookie : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 50;


			Item.useTurn = true;
			Item.consumable = true;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
			Item.buffType = 26;
			Item.buffTime = 3600;
			Item.value = 2000;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Cookie");
	      Tooltip.SetDefault("Have a cookie\nThese are Happy Days");
	    }

		public override bool CanUseItem(Player player)
		{
			return true;
		}
	}
}
namespace imkSushisMod.Items
{
	public class ImkSushisModGlobalNpcForCookies : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Merchant)
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<Cookie>());
				nextSlot++;
			}
		}
	}
}
