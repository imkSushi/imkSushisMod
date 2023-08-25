using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items.TileItems;

public class Melter : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.createTile = ModContent.TileType<Tiles.Melter>();

        Item.width = 20;
        Item.height = 20;

        Item.useTurn = true;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 10;
        Item.useAnimation = 15;

        Item.maxStack = 99;
        Item.consumable = true;
        Item.value = 150;
    }
}