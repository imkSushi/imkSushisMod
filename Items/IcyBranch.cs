using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class IcyBranch : ModItem
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

		public override bool CanUseItem(Player player)
		{
			return Main.snowMoon;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Everscream);
			return base.ConsumeItem(player);
		}
	}
}
