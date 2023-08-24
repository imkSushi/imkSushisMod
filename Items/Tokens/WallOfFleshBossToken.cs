using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class WallOfFleshBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<WallOfFleshBossToken>());

        recipe.From((BreakerBlade, 2));
        recipe.From((ClockworkAssaultRifle, 2));
        recipe.From((LaserRifle, 2));
        recipe.From((FireWhip, 2));
        
        recipe.From((WarriorEmblem, 2));
        recipe.From((RangerEmblem, 2));
        recipe.From((SorcererEmblem, 2));
        recipe.From((SummonerEmblem, 2));
        
        recipe.From((FleshMask, 2));
        recipe.From((WallofFleshTrophy, 2));
        
        
        recipe.To(BreakerBlade);
        recipe.To(ClockworkAssaultRifle);
        recipe.To(LaserRifle);
        recipe.To(FireWhip);
        
        recipe.To(WarriorEmblem);
        recipe.To(RangerEmblem);
        recipe.To(SorcererEmblem);
        recipe.To(SummonerEmblem);
        
        recipe.To(FleshMask);
        recipe.To(WallofFleshTrophy);
    }
}