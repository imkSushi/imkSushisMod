using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class MourningWoodBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<MourningWoodBossToken>());

        recipe.From((SpookyHook, 2));
        recipe.From((SpookyTwig, 2));
        recipe.From((StakeLauncher, 2));
        recipe.From((CursedSapling, 2));
        recipe.From((NecromanticScroll, 2));

        recipe.To(SpookyHook);
        recipe.To(SpookyTwig);
        recipe.To(StakeLauncher);
        recipe.To(CursedSapling);
        recipe.To(NecromanticScroll);
        recipe.To((Stake, 90));
    }
}