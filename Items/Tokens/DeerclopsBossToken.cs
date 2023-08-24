using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class DeerclopsBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<DeerclopsBossToken>());

        recipe.From((ChesterPetItem, 2));
        recipe.From((Eyebrella, 2));
        recipe.From((DontStarveShaderItem, 2));
        recipe.From(DizzyHat);
        
        recipe.From((PewMaticHorn, 2));
        recipe.From((WeatherPain, 2));
        recipe.From((HoundiusShootius, 2));
        recipe.From((LucyTheAxe, 2));
        
        recipe.From((DeerclopsMask, 2));
        recipe.From((DeerclopsTrophy, 2));
        
        
        recipe.To(ChesterPetItem);
        recipe.To(Eyebrella);
        recipe.To(DontStarveShaderItem);
        recipe.To(DizzyHat);
        
        recipe.To(PewMaticHorn);
        recipe.To(WeatherPain);
        recipe.To(HoundiusShootius);
        recipe.To(LucyTheAxe);
        
        recipe.To(DeerclopsMask);
        recipe.To(DeerclopsTrophy);
    }
}