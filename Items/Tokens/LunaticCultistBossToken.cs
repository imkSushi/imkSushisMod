using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class LunaticCultistBossToken : Token
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
        DisplayName.SetDefault("Lunatic Cultist Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<LunaticCultistBossToken>());

        recipe.From((BossMaskCultist, 2));
        recipe.From((LunaticCultistMasterTrophy, 2));
        
        recipe.To(BossMaskCultist);
        recipe.To(LunaticCultistMasterTrophy);
    }
}