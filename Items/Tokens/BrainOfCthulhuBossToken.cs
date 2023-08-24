using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class BrainOfCthulhuBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<BrainOfCthulhuBossToken>());
        
        recipe.From((BrainMask, 2));
        recipe.From((BrainofCthulhuTrophy, 2));
        recipe.From(BoneRattle);
        
        recipe.To(BrainMask);
        recipe.To(BrainofCthulhuTrophy);
        recipe.To(BoneRattle, 2);
    }
}