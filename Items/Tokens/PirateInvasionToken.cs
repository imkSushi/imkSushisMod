using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace imkSushisMod.Items.Tokens;

public class PirateInvasionToken : Token
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
        var recipe = new TokenRecipeCreator(ModContent.ItemType<PirateInvasionToken>());

        recipe.From(CoinGun, 4);
        recipe.From(LuckyCoin, 2);
        recipe.From(DiscountCard);
        recipe.From(PirateStaff);
        recipe.From((Cutlass, 3));

        recipe.From((SailorHat, 2));
        recipe.From((SailorPants, 2));
        recipe.From((SailorShirt, 2));
        recipe.From((EyePatch, 2));

        recipe.From((GoldRing, 2));

        recipe.From((BuccaneerBandana, 2));
        recipe.From((BuccaneerShirt, 2));
        recipe.From((BuccaneerPants, 2));

        recipe.From((GoldenChair, 3));
        recipe.From((GoldenToilet, 3));
        recipe.From((GoldenDoor, 3));
        recipe.From((GoldenTable, 3));
        recipe.From((GoldenBed, 3));
        recipe.From((GoldenLamp, 3));
        recipe.From((GoldenBookcase, 3));
        recipe.From((GoldenChandelier, 3));
        recipe.From((GoldenLantern, 3));
        recipe.From((GoldenCandelabra, 3));
        recipe.From((GoldenCandle, 3));
        recipe.From((GoldenClock, 3));
        recipe.From((GoldenPiano, 3));
        recipe.From((GoldenDresser, 3));
        recipe.From((GoldenSofa, 3));
        recipe.From((GoldenBathtub, 3));
        recipe.From((GoldenSink));
        recipe.From((GoldenChest, 3));
        recipe.From((GoldenPlatform, 240));
        recipe.From((GoldenWorkbench, 3));
        
        recipe.From((PirateMinecart, 2));
        recipe.From((FlyingDutchmanTrophy, 2));
        
        
        recipe.To(CoinGun, 12);
        recipe.To(LuckyCoin, 6);
        recipe.To(DiscountCard, 3);
        recipe.To(PirateStaff, 3);
        recipe.To(Cutlass);
        
        recipe.To(SailorHat);
        recipe.To(SailorPants);
        recipe.To(SailorShirt);
        recipe.To(EyePatch);
        
        recipe.To(GoldRing);
        
        recipe.To(BuccaneerBandana);
        recipe.To(BuccaneerShirt);
        recipe.To(BuccaneerPants);
        
        recipe.To(GoldenChair);
        recipe.To(GoldenToilet);
        recipe.To(GoldenDoor);
        recipe.To(GoldenTable);
        recipe.To(GoldenBed);
        recipe.To(GoldenLamp);
        recipe.To(GoldenBookcase);
        recipe.To(GoldenChandelier);
        recipe.To(GoldenLantern);
        recipe.To(GoldenCandelabra);
        recipe.To(GoldenCandle);
        recipe.To(GoldenClock);
        recipe.To(GoldenPiano);
        recipe.To(GoldenDresser);
        recipe.To(GoldenSofa);
        recipe.To(GoldenBathtub);
        recipe.To(GoldenSink);
        recipe.To(GoldenChest);
        recipe.To((GoldenPlatform, 40));
        recipe.To(GoldenWorkbench);
    }
}