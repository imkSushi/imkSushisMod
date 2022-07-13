using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class PlanteraBossToken : Token
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
        DisplayName.SetDefault("Plantera Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<PlanteraBossToken>());

        recipe.From((GrenadeLauncher, 2));
        recipe.From((VenusMagnum, 2));
        recipe.From((NettleBurst, 2));
        recipe.From((LeafBlower, 2));
        recipe.From((FlowerPow, 2));
        recipe.From((WaspGun, 2));
        recipe.From((Seedler, 2));
        
        recipe.From((PygmyStaff, 2));
        recipe.From((ThornHook, 2));
        recipe.From(TheAxe);
        recipe.From(Seedling);
        
        recipe.From((PlanteraMask, 2));
        recipe.From((PlanteraTrophy, 2));


        recipe.To(GrenadeLauncher);
        recipe.To(VenusMagnum);
        recipe.To(NettleBurst);
        recipe.To(LeafBlower);
        recipe.To(FlowerPow);
        recipe.To(WaspGun);
        recipe.To(Seedler);
        
        recipe.To(PygmyStaff);
        recipe.To(ThornHook);
        recipe.To(TheAxe, 2);
        recipe.To(Seedling, 2);
        
        recipe.To(PlanteraMask);
        recipe.To(PlanteraTrophy);
        
        
        recipe.To(LifeFruit);
    }
}