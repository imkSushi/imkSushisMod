using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class EaterOfWorldsBossToken : Token
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
        DisplayName.SetDefault("Eater of Worlds Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<EaterOfWorldsBossToken>());
        
        recipe.From((EaterMask, 2));
        recipe.From((EaterofWorldsTrophy, 2));
        recipe.From(EatersBone);
        
        recipe.To(EaterMask);
        recipe.To(EaterofWorldsTrophy);
        recipe.To(EatersBone, 2);
    }
}