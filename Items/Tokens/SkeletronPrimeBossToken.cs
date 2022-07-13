using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class SkeletronPrimeBossToken : Token
{
    public override string Texture => (GetType().Namespace + "." + "SwapToken").Replace('.', '/');

    public override void SetDefaults()
    {
        Item.width = 30;
        Item.height = 18;
        Item.rare = ItemRarityID.Blue;
    }

    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Skeletron Prime Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<SkeletronPrimeBossToken>());

        recipe.From((SkeletronPrimeMask, 2));
        recipe.From((SkeletronPrimeTrophy, 2));

        recipe.To(SkeletronPrimeMask);
        recipe.To(SkeletronPrimeTrophy);

        recipe.To((HallowedBar, 15));
        recipe.To((SoulofFright, 25));
    }
}