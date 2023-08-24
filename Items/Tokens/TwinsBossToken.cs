using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class TwinsBossToken : Token
{
    public override string Texture => (GetType().Namespace + "." + "SwapToken").Replace('.', '/');

    public override void SetDefaults()
    {
        Item.width = 30;
        Item.height = 18;
        Item.rare = ItemRarityID.Blue;
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<TwinsBossToken>());

        recipe.From((TwinMask, 2));
        recipe.From((RetinazerTrophy, 2));
        recipe.From((SpazmatismTrophy, 2));

        recipe.To(TwinMask);
        recipe.To(RetinazerTrophy);
        recipe.To(SpazmatismTrophy);

        recipe.To(BlackLens);
        recipe.To((HallowedBar, 15));
        recipe.To((SoulofSight, 25));
    }
}