using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items;

public class Hellmelter : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Hellmelter");
        Tooltip.SetDefault("Used for melting down stuff back into bars and ores");

        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.createTile = ModContent.TileType<Tiles.Hellmelter>();

        Item.width = 20;
        Item.height = 20;

        Item.useTurn = true;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 10;
        Item.useAnimation = 15;

        Item.maxStack = 99;
        Item.consumable = true;
        Item.value = 500;
    }
}