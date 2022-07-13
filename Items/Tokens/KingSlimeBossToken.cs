using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class KingSlimeBossToken : Token
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
        DisplayName.SetDefault("King Slime Boss Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<KingSlimeBossToken>());
        recipe.From((NinjaHood, 2));
        recipe.From((NinjaShirt, 2));
        recipe.From((NinjaPants, 2));
        recipe.From((SlimeHook, 2));
        recipe.From((SlimeGun, 2));
        recipe.From((SlimySaddle, 2));
        
        recipe.From(KingSlimeMask, 2);
        recipe.From(KingSlimeTrophy, 2);
        
        
        recipe.To(NinjaHood);
        recipe.To(NinjaShirt);
        recipe.To(NinjaPants);
        recipe.To(SlimeHook, 2);
        recipe.To(SlimeGun);
        recipe.To(SlimySaddle, 2);
        
        recipe.To(KingSlimeMask);
        recipe.To(KingSlimeTrophy);
        
        
        recipe.To(SlimeStaff, 2);
        recipe.To((PinkGel, 35));
    }
}