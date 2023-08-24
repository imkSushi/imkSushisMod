using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class QueenBeeBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<QueenBeeBossToken>());

        recipe.From((BeeGun, 2));
        recipe.From((BeeKeeper, 2));
        recipe.From((BeesKnees, 2));
        
        recipe.From((HiveWand, 2));
        recipe.From((BeeHat, 2));
        recipe.From((BeeShirt, 2));
        recipe.From((BeePants, 2));
        
        recipe.From((HoneyComb, 2));
        recipe.From(Nectar);
        recipe.From(HoneyedGoggles);
        
        recipe.From((BeeMask, 2));
        recipe.From((QueenBeeTrophy, 2));
        
        
        recipe.To(BeeGun);
        recipe.To(BeeKeeper);
        recipe.To(BeesKnees);
        
        recipe.To(HiveWand);
        recipe.To(BeeHat);
        recipe.To(BeeShirt);
        recipe.To(BeePants);
        
        recipe.To(HoneyComb);
        recipe.To(Nectar, 2);
        recipe.To(HoneyedGoggles, 2);
        
        recipe.To(BeeMask);
        recipe.To(QueenBeeTrophy);
    }
}