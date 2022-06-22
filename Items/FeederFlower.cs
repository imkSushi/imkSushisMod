using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items
{
	public class FeederFlower : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 44;

			Item.rare = ItemRarityID.Blue;
			Item.value = 20000;
			Item.accessory = true;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Feeder Flower");
	      Tooltip.SetDefault("Does what both the Mana and Healing Flower do");
	    }


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<imkSushisPlayer>().HighestHealth();
			player.manaFlower = true;
			player.manaCost -= 0.08f;
		}
	}
}
