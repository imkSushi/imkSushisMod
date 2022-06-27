using Terraria;
using static Terraria.ID.ItemID;
using static Terraria.Localization.Language;
using static Terraria.RecipeGroup;

namespace imkSushisMod;

public static class imkSushiRecipeGroups
{
		
    public static int CopperBars { get; private set; }
    public static int GoldBars { get; private set; }
    public static int Flares { get; private set; }
    public static int CobaltBars { get; private set; }
    public static int DemoniteBars { get; private set; }
    public static int AdamantiteBars { get; private set; }

    public static void AddRecipeGroups()
    {
        CopperBars = RegisterGroup("imkSushisMod:CopperBars",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(CopperBar)}", CopperBar, TinBar));
        GoldBars = RegisterGroup("imkSushisMod:GoldBars",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(GoldBar)}", GoldBar, PlatinumBar));
        Flares = RegisterGroup("imkSushisMod:Flares",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(Flare)}", Flare, BlueFlare));
        CobaltBars = RegisterGroup("imkSushisMod:CobaltBars",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(CobaltBar)}", CobaltBar, PalladiumBar));
        DemoniteBars = RegisterGroup("imkSushisMod:DemoniteBars",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(DemoniteBar)}", DemoniteBar, CrimtaneBar));
        AdamantiteBars = RegisterGroup("imkSushisMod:AdamantiteBars",
            new RecipeGroup(() =>
                $"{GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(AdamantiteBar)}", AdamantiteBar, TitaniumBar));
    }
}