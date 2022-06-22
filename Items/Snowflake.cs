using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class Snowflake : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;


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
	      DisplayName.SetDefault("Frostflake");
	      Tooltip.SetDefault("Wait, but it's only Wave 1...\nThis isn't a snowflake, because it has the wrong number of sides...");
	    }

		public override bool CanUseItem(Player player)
		{
			return Main.snowMoon;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.IceQueen);
			return true;
		}
	}
}
