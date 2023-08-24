using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class GolemBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<GolemBossToken>());

        recipe.From((Picksaw, 2));
        recipe.From((Stynger, 2));
        recipe.From((PossessedHatchet, 2));
        recipe.From((SunStone, 2));
        recipe.From((EyeoftheGolem, 2));
        recipe.From((HeatRay, 2));
        recipe.From((StaffofEarth, 2));
        recipe.From((GolemFist, 2));
        
        recipe.From((GolemMask, 2));
        recipe.From((GolemTrophy, 2));
        
        
        recipe.To(Picksaw);
        recipe.To(Stynger);
        recipe.To(PossessedHatchet);
        recipe.To(SunStone);
        recipe.To(EyeoftheGolem);
        recipe.To(HeatRay);
        recipe.To(StaffofEarth);
        recipe.To(GolemFist);
        
        recipe.To(GolemMask);
        recipe.To(GolemTrophy);
        
        
        recipe.To((StyngerBolt, 159));
    }
}