using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class QueenSlimeBossToken : Token
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
        DisplayName.SetDefault("Queen Slime Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<QueenSlimeBossToken>());

        recipe.From((CrystalNinjaHelmet, 2));
        recipe.From((CrystalNinjaChestplate, 2));
        recipe.From((CrystalNinjaLeggings, 2));

        recipe.From((Smolstar, 2));
        recipe.From((QueenSlimeMountSaddle, 2));
        recipe.From((QueenSlimeHook, 2));
        
        recipe.From((QueenSlimeMask, 2));
        recipe.From((QueenSlimeTrophy, 2));


        recipe.To(CrystalNinjaHelmet);
        recipe.To(CrystalNinjaChestplate);
        recipe.To(CrystalNinjaLeggings);
        
        recipe.To(Smolstar);
        recipe.To(QueenSlimeMountSaddle);
        recipe.To(QueenSlimeHook);
        
        recipe.To(QueenSlimeMask);
        recipe.To(QueenSlimeTrophy);
        
        
        recipe.To(SlimeStaff, 2);
        recipe.To((PinkGel, 35));
    }
}