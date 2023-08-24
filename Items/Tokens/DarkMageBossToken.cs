using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class DarkMageBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<DarkMageBossToken>());

        recipe.From((WarTable, 2));
        recipe.From((WarTableBanner, 2));

        recipe.From((DD2PetDragon, 2));
        recipe.From((DD2PetGato, 2));
        
        recipe.From((BossMaskDarkMage, 2));
        recipe.From((BossTrophyDarkmage, 2));
        
        
        recipe.To(WarTable);
        recipe.To(WarTableBanner);
        
        recipe.To(DD2PetDragon);
        recipe.To(DD2PetGato);
        
        recipe.To(BossMaskDarkMage);
        recipe.To(BossTrophyDarkmage);
    }
}