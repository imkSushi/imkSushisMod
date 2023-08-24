using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class OgreBossToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<OgreBossToken>());

        recipe.From((ApprenticeScarf, 2));
        recipe.From((SquireShield, 2));
        recipe.From((HuntressBuckler, 2));
        recipe.From((MonkBelt, 2));
        
        recipe.From((BookStaff, 2));
        recipe.From((DD2PhoenixBow, 2));
        recipe.From((DD2SquireDemonSword, 2));
        recipe.From((MonkStaffT1, 2));
        recipe.From((MonkStaffT2, 2));
        
        recipe.From((DD2PetGhost, 2));

        recipe.From((BossMaskOgre, 2));
        recipe.From((BossTrophyOgre, 2));
        
        
        recipe.To(ApprenticeScarf);
        recipe.To(SquireShield);
        recipe.To(HuntressBuckler);
        recipe.To(MonkBelt);
        
        recipe.To(BookStaff);
        recipe.To(DD2PhoenixBow);
        recipe.To(DD2SquireDemonSword);
        recipe.To(MonkStaffT1);
        recipe.To(MonkStaffT2);
        
        recipe.To(DD2PetGhost);
        
        recipe.To(BossMaskOgre);
        recipe.To(BossTrophyOgre);
    }
}