using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class EyeOfCthulhuBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<EyeOfCthulhuBossToken>());
        recipe.From((EyeMask, 2));
        recipe.From((EyeofCthulhuTrophy, 2));
        recipe.From(Binoculars);
        
        recipe.To(EyeMask);
        recipe.To(EyeofCthulhuTrophy);
        recipe.To(Binoculars, 2);
        
        recipe.To(BlackLens);
    }
}