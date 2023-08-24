using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class PumpkingBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<PumpkingBossToken>());

        recipe.From((TheHorsemansBlade, 2));
        recipe.From((BatScepter, 2));
        recipe.From((BlackFairyDust, 2));
        recipe.From((SpiderEgg, 2));
        recipe.From((RavenStaff, 2));
        recipe.From((CandyCornRifle, 2));
        recipe.From((JackOLanternLauncher, 2));
        recipe.From((ScytheWhip, 2));
        
        recipe.To(TheHorsemansBlade);
        recipe.To(BatScepter);
        recipe.To(BlackFairyDust);
        recipe.To(SpiderEgg);
        recipe.To(RavenStaff);
        recipe.To(CandyCornRifle);
        recipe.To(JackOLanternLauncher);
        recipe.To(ScytheWhip);
        
        recipe.To((CandyCorn, 150));
        recipe.To((ExplosiveJackOLantern, 75));
    }
}