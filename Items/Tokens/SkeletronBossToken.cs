using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class SkeletronBossToken : Token
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
        DisplayName.SetDefault("Skeletron Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<SkeletronBossToken>());

        recipe.From((SkeletronMask, 2));
        recipe.From((SkeletronHand, 2));
        recipe.From((BookofSkulls, 2));
        
        recipe.From((ChippysCouch, 2));
        recipe.From((SkeletronTrophy, 2));
        
        recipe.To(SkeletronMask);
        recipe.To(SkeletronHand);
        recipe.To(BookofSkulls);
        
        recipe.To(ChippysCouch);
        recipe.To(SkeletronTrophy);
    }
}