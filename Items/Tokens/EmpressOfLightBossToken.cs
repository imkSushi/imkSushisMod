using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class EmpressOfLightBossToken : Token
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
        DisplayName.SetDefault("Empress of Light Loot Swapping Token");
        Tooltip.SetDefault("Lets you swap boss loot");
    }

    public override void AddRecipes()
    {
        var recipe = new TokenRecipeCreator(ModContent.ItemType<EmpressOfLightBossToken>());

        recipe.From((FairyQueenMagicItem, 2));
        recipe.From((PiercingStarlight, 2));
        recipe.From((RainbowWhip, 2));
        recipe.From((FairyQueenRangedItem, 2));
        
        recipe.From(RainbowWings);
        recipe.From((HallowBossDye, 2));
        recipe.From(SparkleGuitar);
        recipe.From(RainbowCursor);
        
        recipe.From(FairyQueenMask);
        recipe.From(FairyQueenTrophy);


        recipe.To(FairyQueenMagicItem);
        recipe.To(PiercingStarlight);
        recipe.To(RainbowWhip);
        recipe.To(FairyQueenRangedItem);
        
        recipe.To(RainbowWings, 2);
        recipe.To(HallowBossDye);
        recipe.To(SparkleGuitar, 2);
        recipe.To(RainbowCursor, 2);
        
        recipe.To(FairyQueenMask);
        recipe.To(FairyQueenTrophy);
    }
}