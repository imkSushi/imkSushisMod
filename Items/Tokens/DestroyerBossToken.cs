using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class DestroyerBossToken : Token
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
        DisplayName.SetDefault("Destroyer Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<DestroyerBossToken>());

        recipe.From((DestroyerMask, 2));
        recipe.From((DestroyerTrophy, 2));

        recipe.To(DestroyerMask);
        recipe.To(DestroyerTrophy);

        recipe.To((HallowedBar, 15));
        recipe.To((SoulofMight, 25));
    }
}