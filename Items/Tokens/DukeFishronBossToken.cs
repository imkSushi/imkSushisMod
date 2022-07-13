using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class DukeFishronBossToken : Token
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
        DisplayName.SetDefault("Duke Fishron Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<DukeFishronBossToken>());

        recipe.From((BubbleGun, 2));
        recipe.From((Flairon, 2));
        recipe.From((RazorbladeTyphoon, 2));
        recipe.From((TempestStaff, 2));
        recipe.From((Tsunami, 2));
        
        recipe.From(FishronWings);
        
        recipe.From((DukeFishronMask, 2));
        recipe.From((DukeFishronTrophy, 2));
        
        
        recipe.To(BubbleGun);
        recipe.To(Flairon);
        recipe.To(RazorbladeTyphoon);
        recipe.To(TempestStaff);
        recipe.To(Tsunami);
        
        recipe.To(FishronWings, 2);
        
        recipe.To(DukeFishronMask);
        recipe.To(DukeFishronTrophy);
    }
}