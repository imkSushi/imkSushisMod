using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class BetsyBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<BetsyBossToken>());

        recipe.From((DD2BetsyBow, 2));
        recipe.From((MonkStaffT3, 2));
        recipe.From((ApprenticeStaffT3, 2));
        recipe.From((DD2SquireBetsySword, 2));

        recipe.From((BetsyWings, 2));

        recipe.From((BossMaskBetsy, 2));
        recipe.From((BossTrophyBetsy, 2));


        recipe.To(DD2BetsyBow);
        recipe.To(MonkStaffT3);
        recipe.To(ApprenticeStaffT3);
        recipe.To(DD2SquireBetsySword);
        
        recipe.To(BetsyWings);
        
        recipe.To(BossMaskBetsy);
        recipe.To(BossTrophyBetsy);
    }
}