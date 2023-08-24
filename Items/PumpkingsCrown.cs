using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class PumpkingsCrown : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 32;


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
			return Main.pumpkinMoon;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Pumpking);
			return true;
		}
	}
}
