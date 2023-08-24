using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
		public override void ModifyShop(NPCShop shop)
		{
			if (shop.NpcType == NPCID.Merchant)
			{
				shop.Add<Cookie>();
			}
		}
	}
}
