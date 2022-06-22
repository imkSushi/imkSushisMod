using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class MysteriousSeed : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 18;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Mysterious Seed");
	      Tooltip.SetDefault("The beginning of the Plant Era");
	    }

		public override bool CanUseItem(Player player)
		{
			return NPC.FindFirstNPC(NPCID.Plantera) <= -1;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
			return true;
		}
	}
}
