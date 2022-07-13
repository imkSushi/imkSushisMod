using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class MoonLordBossToken : Token
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
        DisplayName.SetDefault("Moon Lord Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<MoonLordBossToken>());

        recipe.From((Meowmere, 2));
        recipe.From((Terrarian, 2));
        recipe.From((StarWrath, 2));
        recipe.From((SDMG, 2));
        recipe.From((LastPrism, 2));
        recipe.From((LunarFlareBook, 2));
        recipe.From((RainbowCrystalStaff, 2));
        recipe.From((MoonlordTurretStaff, 2));
        recipe.From((Celeb2, 2));
        
        recipe.From((MeowmereMinecart, 2));
        recipe.From((BossMaskMoonlord, 2));
        recipe.From((MoonLordTrophy, 2));

        
        recipe.To(Meowmere);
        recipe.To(Terrarian);
        recipe.To(StarWrath);
        recipe.To(SDMG);
        recipe.To(LastPrism);
        recipe.To(LunarFlareBook);
        recipe.To(RainbowCrystalStaff);
        recipe.To(MoonlordTurretStaff);
        recipe.To(Celeb2);
        
        recipe.To(MeowmereMinecart);
        recipe.To(BossMaskMoonlord);
        recipe.To(MoonLordTrophy);
    }
}