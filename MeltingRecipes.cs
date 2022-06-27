using System;
using imkSushisMod.Items;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using static Terraria.ID.TileID;
using static Terraria.ModLoader.ModContent;

namespace imkSushisMod;

[GenerateRecipes]
public class MeltingRecipes
{

    public static void AddMelterCraftingRecipes(RecipeCreator recipe)
    {
        recipe.StartNewRecipeSection("Melter Crafting");
        recipe.New(Furnace, (ItemID.ClayBlock, 20), WorkBenches, ItemType<Items.Melter>());
        recipe.New(ItemID.Hellforge, (ItemID.ClayBlock, 20), WorkBenches, ItemType<Items.Hellmelter>());
        recipe.New(ItemID.AdamantiteForge, (ItemID.ClayBlock, 20), WorkBenches, ItemType<Items.AdamantiteMelter>());
        recipe.New(ItemID.TitaniumForge, (ItemID.ClayBlock, 20), WorkBenches, ItemType<Items.TitaniumMelter>());
        
        recipe.New(ItemType<Items.Melter>(), (HellstoneBar, 10), Anvils, (short) ItemType<Items.Hellmelter>());
        recipe.New(ItemType<Items.Hellmelter>(), (AdamantiteOre, 30), TileID.MythrilAnvil, ItemType<Items.AdamantiteMelter>());
        recipe.New(ItemType<Items.Hellmelter>(), (TitaniumOre, 30), TileID.MythrilAnvil, ItemType<Items.TitaniumMelter>());
    }

    public static void AddMeltingDownBarsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Bars");
        recipe.New(CopperBar, melter, (CopperOre, 2));
        recipe.New(TinBar, melter, (TinOre, 2));
        recipe.New(IronBar, melter, (IronOre, 2));
        recipe.New(LeadBar, melter, (LeadOre, 2));
        recipe.New(SilverBar, melter, (SilverOre, 3));
        recipe.New(TungstenBar, melter, (TungstenOre, 3));
        recipe.New(GoldBar, melter, (GoldOre, 3));
        recipe.New(PlatinumBar, melter, (PlatinumOre, 3));
        recipe.New(DemoniteBar, melter, (DemoniteOre, 2));
        recipe.New(CrimtaneBar, melter, (CrimtaneOre, 2));
        recipe.New(MeteoriteBar, melter, (ItemID.Meteorite, 2));
        recipe.New(HellstoneBar, hellmelter, (ItemID.Hellstone, 2));
        recipe.New(HellstoneBar, hellmelter, ItemID.Obsidian);
        recipe.New(CobaltBar, melter, (CobaltOre, 2));
        recipe.New(PalladiumBar, melter, (PalladiumOre, 2));
        recipe.New(MythrilBar, melter, (MythrilOre, 3));
        recipe.New(OrichalcumBar, melter, (OrichalcumOre, 3));
        recipe.New(AdamantiteBar, adamantitemelter, (AdamantiteOre, 3));
        recipe.New(TitaniumBar, adamantitemelter, (TitaniumOre, 3));
        recipe.New(ChlorophyteBar, adamantitemelter, (ChlorophyteOre, 4));
        recipe.New(LunarBar, TileID.LunarCraftingStation, (ItemID.LunarOre, 3));
        recipe.New((SpectreBar, 3), adamantitemelter, Ectoplasm);
        recipe.New((SpectreBar, 3), adamantitemelter, (ChlorophyteBar, 2));
        recipe.New((ShroomiteBar, 3), TileID.Autohammer, (ChlorophyteBar, 2));
        recipe.New(ShroomiteBar, TileID.Autohammer, (GlowingMushroom, 10));
    }

    public static void AddMeltingDownStaffsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Staffs");
        recipe.New(AmethystStaff, melter, (ItemID.Amethyst, 4));
        recipe.New(AmethystStaff, melter, (CopperBar, 5));
        recipe.New(TopazStaff, melter, (ItemID.Topaz, 4));
        recipe.New(TopazStaff, melter, (TinBar, 5));
        recipe.New(SapphireStaff, melter, (ItemID.Sapphire, 4));
        recipe.New(SapphireStaff, melter, (SilverBar, 5));
        recipe.New(EmeraldStaff, melter, (ItemID.Emerald, 4));
        recipe.New(EmeraldStaff, melter, (TungstenBar, 5));
        recipe.New(RubyStaff, melter, (ItemID.Ruby, 4));
        recipe.New(RubyStaff, melter, (GoldBar, 5));
        recipe.New(DiamondStaff, melter, (ItemID.Diamond, 4));
        recipe.New(DiamondStaff, melter, (PlatinumBar, 5));
        recipe.New(AmberStaff, melter, (Amber, 4));
        recipe.New(AmberStaff, melter, (ItemID.FossilOre, 7));
        recipe.New(MeteorStaff, melter, (MeteoriteBar, 10));
        recipe.New(VenomStaff, adamantitemelter, (ChlorophyteBar, 7));
    }

    public static void AddMeltingDownBooksRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Books");
        recipe.New(CursedFlames, melter, (CursedFlame, 10));
        recipe.New(GoldenShower, melter, (Ichor, 10));
        recipe.New(CrystalStorm, melter, (CrystalShard, 10));
        recipe.New(SpiritFlame, melter, AncientBattleArmorMaterial);
        recipe.New(MagicalHarp, melter, (CrystalShard, 10));
        recipe.New(NebulaBlaze, TileID.LunarCraftingStation, (FragmentNebula, 9));
        recipe.New(NebulaArcanum, TileID.LunarCraftingStation, (FragmentNebula, 9));
    }

    public static void AddMeltingDownSummoningWeapons(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Summoning Weapons");
        recipe.New(FlinxStaff, melter, (GoldBar, 10));
        recipe.New(FlinxStaff, melter, (PlatinumBar, 10));
        recipe.New(FlinxStaff, melter, (FlinxFur, 3));
        recipe.New(HornetStaff, melter, (BeeWax, 7));
        recipe.New(ImpStaff, hellmelter, (HellstoneBar, 8));
        recipe.New(SpiderStaff, melter, (SpiderFang, 8));
        recipe.New(OpticStaff, adamantitemelter, (HallowedBar, 6));
        recipe.New(StardustCellStaff, TileID.LunarCraftingStation, (FragmentStardust, 9));
        recipe.New(StardustDragonStaff, TileID.LunarCraftingStation, (FragmentStardust, 9));
        recipe.New(QueenSpiderStaff, melter, (SpiderFang, 12));
        recipe.New(ThornWhip, melter, (Stinger, 6));
        recipe.New(ThornWhip, melter, Vine);
        recipe.New(ThornWhip, melter, JungleSpores);
        recipe.New(BoneWhip, melter, (Bone, 45));
        recipe.New(BoneWhip, melter, (ItemID.Cobweb, 27));
        recipe.New(CoolWhip, melter, FrostCore);
        recipe.New(SwordWhip, adamantitemelter, (HallowedBar, 6));
        
    }

    public static void AddMeltingDownAxesRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Axes");
        recipe.New(CopperAxe, melter, (CopperBar, 3));
        recipe.New(TinAxe, melter, (TinBar, 3));
        recipe.New(IronAxe, melter, (IronBar, 4));
        recipe.New(LeadAxe, melter, (LeadBar, 4));
        recipe.New(SilverAxe, melter, (SilverBar, 4));
        recipe.New(TungstenAxe, melter, (TungstenBar, 4));
        recipe.New(GoldAxe, melter, (GoldBar, 4));
        recipe.New(PlatinumAxe, melter, (PlatinumBar, 4));
        recipe.New(WarAxeoftheNight, melter, (DemoniteBar, 5));
        recipe.New(BloodLustCluster, melter, (CrimtaneBar, 5));
        recipe.New(MeteorHamaxe, melter, (MeteoriteBar, 10));
        recipe.New(MoltenHamaxe, hellmelter, (HellstoneBar, 7));
        recipe.New(CobaltWaraxe, melter, (CobaltBar, 5));
        recipe.New(PalladiumWaraxe, melter, (PalladiumBar, 6));
        recipe.New(MythrilWaraxe, melter, (MythrilBar, 5));
        recipe.New(OrichalcumWaraxe, melter, (OrichalcumBar, 6));
        recipe.New(AdamantiteWaraxe, adamantitemelter, (AdamantiteBar, 6));
        recipe.New(TitaniumWaraxe, adamantitemelter, (TitaniumBar, 6));
        recipe.New(ChlorophyteGreataxe, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(SpectreHamaxe, adamantitemelter, (SpectreBar, 9));
        recipe.New(LunarHamaxeVortex, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(LunarHamaxeVortex, TileID.LunarCraftingStation, (FragmentVortex, 7));
        recipe.New(LunarHamaxeNebula, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(LunarHamaxeNebula, TileID.LunarCraftingStation, (FragmentNebula, 7));
        recipe.New(LunarHamaxeStardust, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(LunarHamaxeStardust, TileID.LunarCraftingStation, (FragmentStardust, 7));
        recipe.New(LunarHamaxeSolar, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(LunarHamaxeSolar, TileID.LunarCraftingStation, (FragmentSolar, 7));
        
        recipe.New(CobaltChainsaw, melter, (CobaltBar, 5));
        recipe.New(PalladiumChainsaw, melter, (PalladiumBar, 6));
        recipe.New(MythrilChainsaw, melter, (MythrilBar, 5));
        recipe.New(OrichalcumChainsaw, adamantitemelter, (OrichalcumBar, 6));
        recipe.New(AdamantiteChainsaw, adamantitemelter, (AdamantiteBar, 6));
        recipe.New(TitaniumChainsaw, adamantitemelter, (TitaniumBar, 6));
        recipe.New(ChlorophyteChainsaw, adamantitemelter, (ChlorophyteBar, 9)); ;
    }

    public static void AddMeltingDownHooksRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Hooks");
        recipe.New(AmethystHook, melter, (ItemID.Amethyst, 7));
        recipe.New(TopazHook, melter, (ItemID.Topaz, 7));
        recipe.New(SapphireHook, melter, (ItemID.Sapphire, 7));
        recipe.New(EmeraldHook, melter, (ItemID.Emerald, 7));
        recipe.New(RubyHook, melter, (ItemID.Ruby, 7));
        recipe.New(DiamondHook, melter, (ItemID.Diamond, 7));
        recipe.New(AmberHook, melter, (Amber, 7));
        recipe.New(IvyWhip, melter, (JungleSpores, 6));
        recipe.New(IvyWhip, melter, Vine);
        recipe.New(LunarHook, TileID.LunarCraftingStation, (FragmentVortex, 3));
        recipe.New(LunarHook, TileID.LunarCraftingStation, (FragmentNebula, 3));
        recipe.New(LunarHook, TileID.LunarCraftingStation, (FragmentStardust, 3));
        recipe.New(LunarHook, TileID.LunarCraftingStation, (FragmentSolar, 3));
    }

    public static void AddMeltingDownSaberRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Phasesabers & Phaseblades");
        recipe.New(BluePhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(BluePhaseblade, melter, (ItemID.Sapphire, 5));
        recipe.New(BluePhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(BluePhasesaber, melter, (ItemID.Sapphire, 5));
        recipe.New(BluePhasesaber, melter, (CrystalShard, 25));
        recipe.New(GreenPhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(GreenPhaseblade, melter, (ItemID.Emerald, 5));
        recipe.New(GreenPhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(GreenPhasesaber, melter, (ItemID.Emerald, 5));
        recipe.New(GreenPhasesaber, melter, (CrystalShard, 25));
        recipe.New(OrangePhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(OrangePhaseblade, melter, (ItemID.Amber, 5));
        recipe.New(OrangePhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(OrangePhasesaber, melter, (ItemID.Amber, 5));
        recipe.New(OrangePhasesaber, melter, (CrystalShard, 25));
        recipe.New(PurplePhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(PurplePhaseblade, melter, (ItemID.Amethyst, 5));
        recipe.New(PurplePhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(PurplePhasesaber, melter, (ItemID.Amethyst, 5));
        recipe.New(PurplePhasesaber, melter, (CrystalShard, 25));
        recipe.New(RedPhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(RedPhaseblade, melter, (ItemID.Ruby, 5));
        recipe.New(RedPhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(RedPhasesaber, melter, (ItemID.Ruby, 5));
        recipe.New(RedPhasesaber, melter, (CrystalShard, 25));
        recipe.New(WhitePhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(WhitePhaseblade, melter, (ItemID.Diamond, 5));
        recipe.New(WhitePhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(WhitePhasesaber, melter, (ItemID.Diamond, 5));
        recipe.New(WhitePhasesaber, melter, (CrystalShard, 25));
        recipe.New(YellowPhaseblade, melter, (MeteoriteBar, 7));
        recipe.New(YellowPhaseblade, melter, (ItemID.Topaz, 5));
        recipe.New(YellowPhasesaber, melter, (MeteoriteBar, 7));
        recipe.New(YellowPhasesaber, melter, (ItemID.Topaz, 5));
        recipe.New(YellowPhasesaber, melter, (CrystalShard, 25));
    }
    
    public static void AddMeltingDownBowsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        var sawmill = TileID.Sawmill;
        
        recipe.StartNewRecipeSection("Melting Down Bows");
        recipe.New(WoodenBow, sawmill, (Wood, 5));
        recipe.New(RichMahoganyBow, sawmill, (ItemID.RichMahogany, 5));
        recipe.New(PearlwoodBow, sawmill, (ItemID.Pearlwood, 5));
        recipe.New(ShadewoodBow, sawmill, (ItemID.Shadewood, 5));
        recipe.New(EbonwoodBow, sawmill, (ItemID.Ebonwood, 5));
        recipe.New(PalmWoodBow, sawmill, (ItemID.PalmWood, 5));
        recipe.New(BorealWoodBow, sawmill, (ItemID.BorealWood, 5));
        recipe.New(CopperBow, melter, (CopperBar, 3));
        recipe.New(TinBow, melter, (TinBar, 3));
        recipe.New(IronBow, melter, (IronBar, 3));
        recipe.New(LeadBow, melter, (LeadBar, 3));
        recipe.New(SilverBow, melter, (SilverBar, 3));
        recipe.New(TungstenBow, melter, (TungstenBar, 3));
        recipe.New(GoldBow, melter, (GoldBar, 3));
        recipe.New(PlatinumBow, melter, (PlatinumBar, 3));
        recipe.New(DemonBow, melter, (DemoniteBar, 4));
        recipe.New(TendonBow, melter, (CrimtaneBar, 4));
        recipe.New(MoltenFury, hellmelter, (HellstoneBar, 7));
        recipe.New(CobaltRepeater, melter, (CobaltBar, 5));
        recipe.New(PalladiumRepeater, melter, (PalladiumBar, 6));
        recipe.New(MythrilRepeater, melter, (MythrilBar, 5));
        recipe.New(OrichalcumRepeater, melter, (OrichalcumBar, 6));
        recipe.New(AdamantiteRepeater, adamantitemelter, (AdamantiteBar, 6));
        recipe.New(TitaniumRepeater, adamantitemelter, (TitaniumBar, 6));
        recipe.New(HallowedRepeater, adamantitemelter, (HallowedBar, 6));
        recipe.New(Phantasm, TileID.LunarCraftingStation, (FragmentVortex, 9));
        
        
    }
    
    public static void AddMeltingDownSwordsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Swords");
        recipe.New(WoodenSword, TileID.Sawmill, (Wood, 3));
        recipe.New(RichMahoganySword, TileID.Sawmill, (ItemID.RichMahogany, 3));
        recipe.New(PearlwoodSword, TileID.Sawmill, (ItemID.Pearlwood, 3));
        recipe.New(ShadewoodSword, TileID.Sawmill, (ItemID.Shadewood, 3));
        recipe.New(EbonwoodSword, TileID.Sawmill, (ItemID.Ebonwood, 3));
        recipe.New(PalmWoodSword, TileID.Sawmill, (ItemID.PalmWood, 3));
        recipe.New(BorealWoodSword, TileID.Sawmill, (ItemID.BorealWood, 3));
        recipe.New(CactusSword, TileID.Sawmill, (ItemID.Cactus, 5));
        recipe.New(CopperShortsword, melter, (CopperBar, 2));
        recipe.New(CopperBroadsword, melter, (CopperBar, 3)); 
        recipe.New(TinShortsword, melter, (TinBar, 2));
        recipe.New(TinBroadsword, melter, (TinBar, 3));
        recipe.New(IronShortsword, melter, (IronBar, 3));
        recipe.New(IronBroadsword, melter, (IronBar, 4));
        recipe.New(LeadShortsword, melter, (LeadBar, 3));
        recipe.New(LeadBroadsword, melter, (LeadBar, 4));
        recipe.New(SilverShortsword, melter, (SilverBar, 3));
        recipe.New(SilverBroadsword, melter, (SilverBar, 4));
        recipe.New(TungstenShortsword, melter, (TungstenBar, 3));
        recipe.New(TungstenBroadsword, melter, (TungstenBar, 4));
        recipe.New(GoldShortsword, melter, (GoldBar, 3));
        recipe.New(GoldBroadsword, melter, (GoldBar, 4));
        recipe.New(PlatinumShortsword, melter, (PlatinumBar, 3));
        recipe.New(PlatinumBroadsword, melter, (PlatinumBar, 4));
        recipe.New(LightsBane, melter, (DemoniteBar, 5));
        recipe.New(BloodButcherer, melter, (CrimtaneBar, 5));
        recipe.New(FieryGreatsword, hellmelter, (HellstoneBar, 10));
        recipe.New(Excalibur, adamantitemelter, (HallowedBar, 6));
        recipe.New(BladeofGrass, melter, (JungleSpores, 6));
        recipe.New(BladeofGrass, melter, (Stinger, 6));
        recipe.New(CobaltSword, melter, (CobaltBar, 4));
        recipe.New(PalladiumSword, melter, (PalladiumBar, 5));
        recipe.New(MythrilSword, melter, (MythrilBar, 4));
        recipe.New(OrichalcumSword, adamantitemelter, (OrichalcumBar, 5));
        recipe.New(AdamantiteSword, adamantitemelter, (AdamantiteBar, 5));
        recipe.New(TitaniumSword, adamantitemelter, (TitaniumBar, 5));
        recipe.New(ChlorophyteSaber, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(ChlorophyteClaymore, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(TrueExcalibur, adamantitemelter, (HallowedBar, 6));
        recipe.New(TrueExcalibur, adamantitemelter, (ChlorophyteBar, 12));
    }

    public static void AddMeltingDownSpearsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Spears");
        recipe.New(CobaltNaginata, melter, (CobaltBar, 5));
        recipe.New(PalladiumPike, melter, (PalladiumBar, 6));
        recipe.New(MythrilHalberd, melter, (MythrilBar, 5));
        recipe.New(OrichalcumHalberd, adamantitemelter, (OrichalcumBar, 6));
        recipe.New(AdamantiteGlaive, adamantitemelter, (AdamantiteBar, 6));
        recipe.New(TitaniumTrident, adamantitemelter, (TitaniumBar, 6));
        recipe.New(Gungnir, adamantitemelter, (HallowedBar, 6));
        recipe.New(ChlorophytePartisan, adamantitemelter, (ChlorophyteBar, 6));
    }
    
    public static void AddMeltingDownArmorRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Armor");
        recipe.New(WoodHelmet, TileID.Sawmill, (Wood, 10));
        recipe.New(WoodBreastplate, TileID.Sawmill, (Wood, 15));
        recipe.New(WoodGreaves, TileID.Sawmill, (Wood, 12));
        recipe.New(RichMahoganyHelmet, TileID.Sawmill, (ItemID.RichMahogany, 10));
        recipe.New(RichMahoganyBreastplate, TileID.Sawmill, (ItemID.RichMahogany, 15));
        recipe.New(RichMahoganyGreaves, TileID.Sawmill, (ItemID.RichMahogany, 12));
        recipe.New(PearlwoodHelmet, TileID.Sawmill, (ItemID.Pearlwood, 10));
        recipe.New(PearlwoodBreastplate, TileID.Sawmill, (ItemID.Pearlwood, 15));
        recipe.New(PearlwoodGreaves, TileID.Sawmill, (ItemID.Pearlwood, 12));
        recipe.New(ShadewoodHelmet, TileID.Sawmill, (ItemID.Shadewood, 10));
        recipe.New(ShadewoodBreastplate, TileID.Sawmill, (ItemID.Shadewood, 15));
        recipe.New(ShadewoodGreaves, TileID.Sawmill, (ItemID.Shadewood, 12));
        recipe.New(BorealWoodHelmet, TileID.Sawmill, (ItemID.BorealWood, 10));
        recipe.New(BorealWoodBreastplate, TileID.Sawmill, (ItemID.BorealWood, 15));
        recipe.New(BorealWoodGreaves, TileID.Sawmill, (ItemID.BorealWood, 12));
        recipe.New(PalmWoodHelmet, TileID.Sawmill, (ItemID.PalmWood, 10));
        recipe.New(PalmWoodBreastplate, TileID.Sawmill, (ItemID.PalmWood, 15));
        recipe.New(PalmWoodGreaves, TileID.Sawmill, (ItemID.PalmWood, 12));
        recipe.New(EbonwoodHelmet, TileID.Sawmill, (ItemID.Ebonwood, 10));
        recipe.New(EbonwoodBreastplate, TileID.Sawmill, (ItemID.Ebonwood, 15));
        recipe.New(EbonwoodGreaves, TileID.Sawmill, (ItemID.Ebonwood, 12));
        recipe.New(CactusHelmet, TileID.Sawmill, (ItemID.Cactus, 10));
        recipe.New(CactusBreastplate, TileID.Sawmill, (ItemID.Cactus, 15));
        recipe.New(CactusLeggings, TileID.Sawmill, (ItemID.Cactus, 12));
        recipe.New(PumpkinHelmet, TileID.Sawmill, (ItemID.Pumpkin, 10));
        recipe.New(PumpkinBreastplate, TileID.Sawmill, (ItemID.Pumpkin, 15));
        recipe.New(PumpkinLeggings, TileID.Sawmill, (ItemID.Pumpkin, 12));
        recipe.New(CopperHelmet, melter, (CopperBar, 6));
        recipe.New(CopperChainmail, melter, (CopperBar, 10));
        recipe.New(CopperGreaves, melter, (CopperBar, 8));
        recipe.New(TinHelmet, melter, (TinBar, 6));
        recipe.New(TinChainmail, melter, (TinBar, 10));
        recipe.New(TinGreaves, melter, (TinBar, 8));
        recipe.New(IronHelmet, melter, (IronBar, 7));
        recipe.New(AncientIronHelmet, melter, (IronBar, 7));
        recipe.New(IronChainmail, melter, (IronBar, 12));
        recipe.New(IronGreaves, melter, (IronBar, 10));
        recipe.New(LeadHelmet, melter, (LeadBar, 7));
        recipe.New(LeadChainmail, melter, (LeadBar, 12));
        recipe.New(LeadGreaves, melter, (LeadBar, 10));
        recipe.New(SilverHelmet, melter, (SilverBar, 7));
        recipe.New(SilverChainmail, melter, (SilverBar, 12));
        recipe.New(SilverGreaves, melter, (SilverBar, 10));
        recipe.New(TungstenHelmet, melter, (TungstenBar, 7));
        recipe.New(TungstenChainmail, melter, (TungstenBar, 12));
        recipe.New(TungstenGreaves, melter, (TungstenBar, 10));
        recipe.New(GoldHelmet, melter, (GoldBar, 10));
        recipe.New(AncientGoldHelmet, melter, (GoldBar, 10));
        recipe.New(GoldChainmail, melter, (GoldBar, 15));
        recipe.New(GoldGreaves, melter, (GoldBar, 12));
        recipe.New(GoldCrown, melter, (GoldBar, 2));
        recipe.New(PlatinumHelmet, melter, (PlatinumBar, 10));
        recipe.New(PlatinumChainmail, melter, (PlatinumBar, 15));
        recipe.New(PlatinumGreaves, melter, (PlatinumBar, 12));
        recipe.New(PlatinumCrown, melter, (PlatinumBar, 2));
        recipe.New(ShadowHelmet, melter, (DemoniteBar, 7));
        recipe.New(ShadowHelmet, melter, (ShadowScale, 5));
        recipe.New(ShadowScalemail, melter, (DemoniteBar, 12));
        recipe.New(ShadowScalemail, melter, (ShadowScale, 10));
        recipe.New(ShadowGreaves, melter, (DemoniteBar, 10));
        recipe.New(ShadowGreaves, melter, (ShadowScale, 7));
        recipe.New(AncientShadowHelmet, melter, (DemoniteBar, 7));
        recipe.New(AncientShadowHelmet, melter, (ShadowScale, 5));
        recipe.New(AncientShadowScalemail, melter, (DemoniteBar, 12));
        recipe.New(AncientShadowScalemail, melter, (ShadowScale, 10));
        recipe.New(AncientShadowGreaves, melter, (DemoniteBar, 10));
        recipe.New(AncientShadowGreaves, melter, (ShadowScale, 7));
        recipe.New(CrimsonHelmet, melter, (CrimtaneBar, 7));
        recipe.New(CrimsonHelmet, melter, (TissueSample, 5));
        recipe.New(CrimsonScalemail, melter, (CrimtaneBar, 12));
        recipe.New(CrimsonScalemail, melter, (TissueSample, 10));
        recipe.New(CrimsonGreaves, melter, (CrimtaneBar, 10));
        recipe.New(CrimsonGreaves, melter, (TissueSample, 7));
        recipe.New(MeteorHelmet, melter, (MeteoriteBar, 5));
        recipe.New(MeteorSuit, melter, (MeteoriteBar, 10));
        recipe.New(MeteorLeggings, melter, (MeteoriteBar, 7));
        recipe.New(MoltenHelmet, hellmelter, (HellstoneBar, 5));
        recipe.New(MoltenBreastplate, hellmelter, (HellstoneBar, 10));
        recipe.New(MoltenGreaves, hellmelter, (HellstoneBar, 7));
        recipe.New(FossilHelm, melter, (ItemID.FossilOre, 7));
        recipe.New(FossilShirt, melter, (ItemID.FossilOre, 12));
        recipe.New(FossilPants, melter, (ItemID.FossilOre, 10));
        recipe.New(BeeHeadgear, melter, (ItemID.BeeWax, 4));
        recipe.New(BeeBreastplate, melter, (ItemID.BeeWax, 6));
        recipe.New(BeeGreaves, melter, (ItemID.BeeWax, 5));
        recipe.New(ObsidianHelm, hellmelter, (ItemID.Obsidian, 10));
        recipe.New(ObsidianHelm, hellmelter, (ShadowScale, 2));
        recipe.New(ObsidianHelm, hellmelter, (TissueSample, 2));
        recipe.New(ObsidianShirt, hellmelter, (ItemID.Obsidian, 10));
        recipe.New(ObsidianShirt, hellmelter, (ShadowScale, 5));
        recipe.New(ObsidianShirt, hellmelter, (TissueSample, 5));
        recipe.New(ObsidianPants, hellmelter, (ItemID.Obsidian, 10));
        recipe.New(ObsidianPants, hellmelter, (ShadowScale, 2));
        recipe.New(ObsidianPants, hellmelter, (TissueSample, 2));
        recipe.New(JungleHat, melter, (ItemID.JungleSpores, 4));
        recipe.New(JungleShirt, melter, (ItemID.JungleSpores, 8));
        recipe.New(JungleShirt, melter, (Stinger, 5));
        recipe.New(JunglePants, melter, (ItemID.JungleSpores, 4));
        recipe.New(JunglePants, melter, Vine);
        recipe.New(NecroHelmet, TileID.Sawmill, (Bone, 20));
        recipe.New(NecroHelmet, TileID.Sawmill, (ItemID.Cobweb, 20));
        recipe.New(AncientNecroHelmet, TileID.Sawmill, (Bone, 20));
        recipe.New(AncientNecroHelmet, TileID.Sawmill, (ItemID.Cobweb, 20));
        recipe.New(NecroBreastplate, TileID.Sawmill, (Bone, 30));
        recipe.New(NecroBreastplate, TileID.Sawmill, (ItemID.Cobweb, 25));
        recipe.New(NecroGreaves, TileID.Sawmill, (Bone, 25));
        recipe.New(NecroGreaves, TileID.Sawmill, (ItemID.Cobweb, 22));
        recipe.New(SpiderMask, melter, (SpiderFang, 4));
        recipe.New(SpiderBreastplate, melter, (SpiderFang, 8));
        recipe.New(SpiderGreaves, melter, (SpiderFang, 6));
        recipe.New(CobaltHat, melter, (CobaltBar, 5));
        recipe.New(CobaltHelmet, melter, (CobaltBar, 5));
        recipe.New(CobaltMask, melter, (CobaltBar, 5));
        recipe.New(CobaltBreastplate, melter, (CobaltBar, 10));
        recipe.New(CobaltLeggings, melter, (CobaltBar, 7));
        recipe.New(PalladiumHeadgear, melter, (PalladiumBar, 6));
        recipe.New(PalladiumHelmet, melter, (PalladiumBar, 6));
        recipe.New(PalladiumMask, melter, (PalladiumBar, 6));
        recipe.New(PalladiumBreastplate, melter, (PalladiumBar, 12));
        recipe.New(PalladiumLeggings, melter, (PalladiumBar, 9));
        recipe.New(MythrilHelmet, melter, (MythrilBar, 5));
        recipe.New(MythrilHat, melter, (MythrilBar, 5));
        recipe.New(MythrilHood, melter, (MythrilBar, 5));
        recipe.New(MythrilChainmail, melter, (MythrilBar, 10));
        recipe.New(MythrilGreaves, melter, (MythrilBar, 7));
        recipe.New(OrichalcumHelmet, melter, (OrichalcumBar, 6));
        recipe.New(OrichalcumHeadgear, melter, (OrichalcumBar, 6));
        recipe.New(OrichalcumMask, melter, (OrichalcumBar, 6));
        recipe.New(OrichalcumBreastplate, melter, (OrichalcumBar, 12));
        recipe.New(OrichalcumLeggings, melter, (OrichalcumBar, 9));
        recipe.New(AdamantiteHeadgear, melter, (AdamantiteBar, 6));
        recipe.New(AdamantiteHelmet, melter, (AdamantiteBar, 6));
        recipe.New(AdamantiteMask, melter, (AdamantiteBar, 6));
        recipe.New(AdamantiteBreastplate, melter, (AdamantiteBar, 12));
        recipe.New(AdamantiteLeggings, melter, (AdamantiteBar, 9));
        recipe.New(TitaniumHelmet, melter, (TitaniumBar, 6));
        recipe.New(TitaniumHeadgear, melter, (TitaniumBar, 6));
        recipe.New(TitaniumMask, melter, (TitaniumBar, 6));
        recipe.New(TitaniumBreastplate, melter, (TitaniumBar, 13));
        recipe.New(TitaniumLeggings, melter, (TitaniumBar, 10));
        recipe.New(FrostHelmet, adamantitemelter, FrostCore);
        recipe.New(FrostHelmet, adamantitemelter, (AdamantiteBar, 5));
        recipe.New(FrostHelmet, adamantitemelter, (TitaniumBar, 5));
        recipe.New(FrostBreastplate, adamantitemelter, FrostCore);
        recipe.New(FrostBreastplate, adamantitemelter, (AdamantiteBar, 10));
        recipe.New(FrostBreastplate, adamantitemelter, (TitaniumBar, 10));
        recipe.New(FrostLeggings, adamantitemelter, FrostCore);
        recipe.New(FrostLeggings, adamantitemelter, (AdamantiteBar, 8));
        recipe.New(FrostLeggings, adamantitemelter, (TitaniumBar, 8));
        recipe.New(AncientBattleArmorHat, adamantitemelter, (AdamantiteBar, 5));
        recipe.New(AncientBattleArmorHat, adamantitemelter, (TitaniumBar, 5));
        recipe.New(AncientBattleArmorHat, adamantitemelter, AncientBattleArmorMaterial);
        recipe.New(AncientBattleArmorShirt, adamantitemelter, (AdamantiteBar, 10));
        recipe.New(AncientBattleArmorShirt, adamantitemelter, (TitaniumBar, 10));
        recipe.New(AncientBattleArmorShirt, adamantitemelter, AncientBattleArmorMaterial);
        recipe.New(AncientBattleArmorPants, adamantitemelter, (AdamantiteBar, 8));
        recipe.New(AncientBattleArmorPants, adamantitemelter, (TitaniumBar, 8));
        recipe.New(AncientBattleArmorPants, adamantitemelter, AncientBattleArmorMaterial);
        recipe.New(HallowedHeadgear, adamantitemelter, (HallowedBar, 6));
        recipe.New(HallowedHelmet, adamantitemelter, (HallowedBar, 6));
        recipe.New(HallowedMask, adamantitemelter, (HallowedBar, 6));
        recipe.New(HallowedHood, adamantitemelter, (HallowedBar, 6));
        recipe.New(HallowedPlateMail, adamantitemelter, (HallowedBar, 12));
        recipe.New(HallowedGreaves, adamantitemelter, (HallowedBar, 9));
        recipe.New(AncientHallowedHeadgear, adamantitemelter, (HallowedBar, 6));
        recipe.New(AncientHallowedHelmet, adamantitemelter, (HallowedBar, 6));
        recipe.New(AncientHallowedMask, adamantitemelter, (HallowedBar, 6));
        recipe.New(AncientHallowedHood, adamantitemelter, (HallowedBar, 12));
        recipe.New(AncientHallowedPlateMail, adamantitemelter, (HallowedBar, 12));
        recipe.New(AncientHallowedGreaves, adamantitemelter, (HallowedBar, 9));
        recipe.New(ChlorophyteHelmet, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(ChlorophyteHeadgear, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(ChlorophyteMask, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(ChlorophytePlateMail, adamantitemelter, (ChlorophyteBar, 12));
        recipe.New(ChlorophyteGreaves, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(TurtleHelmet, adamantitemelter, TurtleShell);
        recipe.New(TurtleHelmet, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(TurtleScaleMail, adamantitemelter, TurtleShell);
        recipe.New(TurtleScaleMail, adamantitemelter, (ChlorophyteBar, 12));
        recipe.New(TurtleLeggings, adamantitemelter, TurtleShell);
        recipe.New(TurtleLeggings, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(BeetleHelmet, adamantitemelter, (BeetleHusk, 2));
        recipe.New(BeetleHelmet, adamantitemelter, (ChlorophyteBar, 6));
        recipe.New(BeetleScaleMail, adamantitemelter, (BeetleHusk, 4));
        recipe.New(BeetleScaleMail, adamantitemelter, (ChlorophyteBar, 12));
        recipe.New(BeetleShell, adamantitemelter, (BeetleHusk, 4));
        recipe.New(BeetleShell, adamantitemelter, (ChlorophyteBar, 12));
        recipe.New(BeetleLeggings, adamantitemelter, (BeetleHusk, 3));
        recipe.New(BeetleLeggings, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(ShroomiteHeadgear, TileID.Autohammer, (ShroomiteBar, 6));
        recipe.New(ShroomiteHelmet, TileID.Autohammer, (ShroomiteBar, 6));
        recipe.New(ShroomiteMask, TileID.Autohammer, (ShroomiteBar, 6));
        recipe.New(ShroomiteBreastplate, TileID.Autohammer, (ShroomiteBar, 12));
        recipe.New(ShroomiteLeggings, TileID.Autohammer, (ShroomiteBar, 9));
        recipe.New(SpectreHood, adamantitemelter, (SpectreBar, 6));
        recipe.New(SpectreMask, adamantitemelter, (SpectreBar, 6));
        recipe.New(SpectreRobe, adamantitemelter, (SpectreBar, 12));
        recipe.New(SpectrePants, adamantitemelter, (SpectreBar, 9));
        recipe.New(SpookyHelmet, TileID.Sawmill, (ItemID.SpookyWood, 100));
        recipe.New(SpookyBreastplate, TileID.Sawmill, (ItemID.SpookyWood, 150));
        recipe.New(SpookyLeggings, TileID.Sawmill, (ItemID.SpookyWood, 125));
        recipe.New(SolarFlareHelmet, TileID.LunarCraftingStation, (FragmentSolar, 5));
        recipe.New(SolarFlareHelmet, TileID.LunarCraftingStation, (LunarBar, 4));
        recipe.New(SolarFlareBreastplate, TileID.LunarCraftingStation, (FragmentSolar, 10));
        recipe.New(SolarFlareBreastplate, TileID.LunarCraftingStation, (LunarBar, 8));
        recipe.New(SolarFlareLeggings, TileID.LunarCraftingStation, (FragmentSolar, 7));
        recipe.New(SolarFlareLeggings, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(VortexHelmet, TileID.LunarCraftingStation, (FragmentVortex, 5));
        recipe.New(VortexHelmet, TileID.LunarCraftingStation, (LunarBar, 4));
        recipe.New(VortexBreastplate, TileID.LunarCraftingStation, (FragmentVortex, 10));
        recipe.New(VortexBreastplate, TileID.LunarCraftingStation, (LunarBar, 8));
        recipe.New(VortexLeggings, TileID.LunarCraftingStation, (FragmentVortex, 7));
        recipe.New(VortexLeggings, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(NebulaHelmet, TileID.LunarCraftingStation, (FragmentNebula, 5));
        recipe.New(NebulaHelmet, TileID.LunarCraftingStation, (LunarBar, 4));
        recipe.New(NebulaBreastplate, TileID.LunarCraftingStation, (FragmentNebula, 10));
        recipe.New(NebulaBreastplate, TileID.LunarCraftingStation, (LunarBar, 8));
        recipe.New(NebulaLeggings, TileID.LunarCraftingStation, (FragmentNebula, 7));
        recipe.New(NebulaLeggings, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(StardustHelmet, TileID.LunarCraftingStation, (FragmentStardust, 5));
        recipe.New(StardustHelmet, TileID.LunarCraftingStation, (LunarBar, 4));
        recipe.New(StardustBreastplate, TileID.LunarCraftingStation, (FragmentStardust, 10));
        recipe.New(StardustBreastplate, TileID.LunarCraftingStation, (LunarBar, 8));
        recipe.New(StardustLeggings, TileID.LunarCraftingStation, (FragmentStardust, 7));
        recipe.New(StardustLeggings, TileID.LunarCraftingStation, (LunarBar, 6));
        recipe.New(AmethystRobe, melter, (ItemID.Amethyst, 5));
        recipe.New(TopazRobe, melter, (ItemID.Topaz, 5));
        recipe.New(SapphireRobe, melter, (ItemID.Sapphire, 5));
        recipe.New(EmeraldRobe, melter, (ItemID.Emerald, 5));
        recipe.New(RubyRobe, melter, (ItemID.Ruby, 5));
        recipe.New(DiamondRobe, melter, (ItemID.Diamond, 5));
        recipe.New(AmberRobe, melter, (ItemID.Amber, 5));
        recipe.New(EmptyBucket, melter, IronBar);
        recipe.New(EmptyBucket, melter, LeadBar);
        recipe.New(FlinxFurCoat, melter, (FlinxFur, 4));
        recipe.New(FlinxFurCoat, melter, (GoldBar, 4));
        recipe.New(FlinxFurCoat, melter, (PlatinumBar, 4));
    }
    
    public static void AddMeltingDownHammersRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Hammers");
        recipe.New(WoodenHammer, TileID.Sawmill, (Wood, 4));
        recipe.New(RichMahoganyHammer, TileID.Sawmill, (ItemID.RichMahogany, 4));
        recipe.New(PalmWoodHammer, TileID.Sawmill, (ItemID.PalmWood, 4));
        recipe.New(PearlwoodHammer, TileID.Sawmill, (ItemID.Pearlwood, 4));
        recipe.New(EbonwoodHammer, TileID.Sawmill, (ItemID.Ebonwood, 4));
        recipe.New(ShadewoodHammer, TileID.Sawmill, (ItemID.Shadewood, 4));
        recipe.New(BorealWoodHammer, TileID.Sawmill, (ItemID.BorealWood, 4));
        recipe.New(CopperHammer, melter, (CopperBar, 4));
        recipe.New(TinHammer, melter, (TinBar, 4));
        recipe.New(IronHammer, melter, (IronBar, 4));
        recipe.New(LeadHammer, melter, (LeadBar, 4));
        recipe.New(SilverHammer, melter, (SilverBar, 4));
        recipe.New(TungstenHammer, melter, (TungstenBar, 4));
        recipe.New(GoldHammer, melter, (GoldBar, 4));
        recipe.New(PlatinumHammer, melter, (PlatinumBar, 4));
        recipe.New(TheBreaker, melter, (DemoniteBar, 5));
        recipe.New(TheBreaker, melter, (ShadowScale, 2));
        recipe.New(FleshGrinder, melter, (CrimtaneBar, 5));
        recipe.New(FleshGrinder, melter, (TissueSample, 2));
        recipe.New(Pwnhammer, adamantitemelter, (HallowedBar, 9));
        recipe.New(ChlorophyteWarhammer, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(ChlorophyteJackhammer, adamantitemelter, (ChlorophyteBar, 9));
    }

    public static void MeltingDownGunsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Guns");
        recipe.New(SpaceGun, melter, (MeteoriteBar, 10));
        recipe.New(StarCannon, melter, (MeteoriteBar, 10));
        recipe.New(SuperStarCannon, melter, (MeteoriteBar, 10));
        recipe.New(SuperStarCannon, adamantitemelter, (HallowedBar, 6));
        recipe.New(PhoenixBlaster, hellmelter, (HellstoneBar, 5));
        recipe.New(VortexBeater, TileID.LunarCraftingStation, (FragmentVortex, 9));
    }

    public static void AddMeltingDownPickaxesRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Pickaxes");
        recipe.New(CactusPickaxe, TileID.Sawmill, (ItemID.Cactus, 7));
        recipe.New(CopperPickaxe, melter, (CopperBar, 4));
        recipe.New(TinPickaxe, melter, (TinBar, 4));
        recipe.New(IronPickaxe, melter, (IronBar, 5));
        recipe.New(LeadPickaxe, melter, (LeadBar, 5));
        recipe.New(SilverPickaxe, melter, (SilverBar, 5));
        recipe.New(TungstenPickaxe, melter, (TungstenBar, 5));
        recipe.New(GoldPickaxe, melter, (GoldBar, 5));
        recipe.New(PlatinumPickaxe, melter, (PlatinumBar, 5));
        recipe.New(NightmarePickaxe, melter, (DemoniteBar, 6));
        recipe.New(NightmarePickaxe, melter, (ShadowScale, 3));
        recipe.New(DeathbringerPickaxe, melter, (CrimtaneBar, 6));
        recipe.New(DeathbringerPickaxe, melter, (TissueSample, 3));
        recipe.New(MoltenPickaxe, hellmelter, (HellstoneBar, 10));
        recipe.New(Drax, melter, (HallowedBar, 9));
        recipe.New(PickaxeAxe, melter, (HallowedBar, 9));
        recipe.New(FossilPickaxe, melter, (ItemID.FossilOre, 6));
        recipe.New(CobaltPickaxe, melter, (CobaltBar, 7));
        recipe.New(CobaltDrill, melter, (CobaltBar, 7));
        recipe.New(PalladiumPickaxe, melter, (PalladiumBar, 7));
        recipe.New(PalladiumDrill, melter, (PalladiumBar, 9));
        recipe.New(MythrilPickaxe, melter, (MythrilBar, 7));
        recipe.New(MythrilDrill, melter, (MythrilBar, 7));
        recipe.New(OrichalcumPickaxe, melter, (OrichalcumBar, 9));
        recipe.New(OrichalcumDrill, melter, (OrichalcumBar, 9));
        recipe.New(AdamantitePickaxe, adamantitemelter, (AdamantiteBar, 9));
        recipe.New(AdamantiteDrill, adamantitemelter, (AdamantiteBar, 9));
        recipe.New(TitaniumPickaxe, adamantitemelter, (TitaniumBar, 10));
        recipe.New(TitaniumDrill, adamantitemelter, (TitaniumBar, 10));
        recipe.New(SpectrePickaxe, adamantitemelter, (SpectreBar, 9));
        recipe.New(ChlorophytePickaxe, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(ChlorophyteDrill, adamantitemelter, (ChlorophyteBar, 9));
        recipe.New(ShroomiteDiggingClaw, adamantitemelter, (ShroomiteBar, 9));
        recipe.New(VortexPickaxe, TileID.LunarCraftingStation, (FragmentVortex, 6));
        recipe.New(VortexPickaxe, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(VortexDrill, TileID.LunarCraftingStation, (FragmentVortex, 6));
        recipe.New(VortexDrill, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(SolarFlarePickaxe, TileID.LunarCraftingStation, (FragmentSolar, 6));
        recipe.New(SolarFlarePickaxe, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(SolarFlareDrill, TileID.LunarCraftingStation, (FragmentSolar, 6));
        recipe.New(SolarFlareDrill, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(NebulaPickaxe, TileID.LunarCraftingStation, (FragmentNebula, 6));
        recipe.New(NebulaPickaxe, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(NebulaDrill, TileID.LunarCraftingStation, (FragmentNebula, 6));
        recipe.New(NebulaDrill, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(StardustPickaxe, TileID.LunarCraftingStation, (FragmentStardust, 6));
        recipe.New(StardustPickaxe, TileID.LunarCraftingStation, (LunarBar, 5));
        recipe.New(StardustDrill, TileID.LunarCraftingStation, (FragmentStardust, 6));
        recipe.New(StardustDrill, TileID.LunarCraftingStation, (LunarBar, 5));
    }

    public static void AddMeltingDownYoyosRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Yoyos");
        recipe.New(CorruptYoyo, melter, (DemoniteBar, 6));
        recipe.New(CrimsonYoyo, melter, (DemoniteBar, 6));
        recipe.New(Chik, melter, (CrystalShard, 7));
    }

    public static void AddMeltingDownFishingRodsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Fishing Rods");
        recipe.New(ReinforcedFishingPole, melter, (IronBar, 4));
        recipe.New(ReinforcedFishingPole, melter, (LeadBar, 4));
        recipe.New(FisherofSouls, melter, (DemoniteBar, 4));
        recipe.New(Fleshcatcher, melter, (CrimtaneBar, 4));
    }

    public static void AddMeltingDownFlailsRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Flails");
        recipe.New(TheMeatball, melter, (CrimtaneBar, 5));
        recipe.New(TheMeatball, melter, (TissueSample, 2));
        recipe.New(BallOHurt, melter, (DemoniteBar, 5));
        recipe.New(BallOHurt, melter, (ShadowScale, 2));
    }

    //chests, chandeliers, doors, clocks, furniture, crafting stations etc.
    
    public static void AddMeltingDownOthersRecipes(RecipeCreator recipe)
    {
        var melter = TileType<Tiles.Melter>();
        var hellmelter = TileType<Tiles.Hellmelter>();
        var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
        
        recipe.StartNewRecipeSection("Melting Down Others");
        recipe.New(CopperWatch, melter, (CopperBar, 5));
        recipe.New(TinWatch, melter, (TinBar, 5));
        recipe.New(SilverWatch, melter, (SilverBar, 5));
        recipe.New(TungstenWatch, melter, (TungstenBar, 5));
        recipe.New(GoldWatch, melter, (GoldBar, 5));
        recipe.New(PlatinumWatch, melter, (PlatinumBar, 5));
        recipe.New(Magiluminescence, melter, (DemoniteBar, 6));
        recipe.New(Magiluminescence, melter, (CrimtaneBar, 6));
        recipe.New(Magiluminescence, melter, (ItemID.Topaz, 2));
        recipe.New(FireproofBugNet, hellmelter, (HellstoneBar, 7));
        recipe.New(Flamarang, hellmelter, (HellstoneBar, 5));
        recipe.New((ItemID.Chain, 15), melter, IronBar);
        recipe.New((ItemID.Chain, 15), melter, LeadBar);
        recipe.New(LightDisc, adamantitemelter, (HallowedBar, 2));
        recipe.New(ThornChakram, melter, (JungleSpores, 3));
        recipe.New(ThornChakram, melter, (Stinger, 4));
        recipe.New(HallowJoustingLance, adamantitemelter, (HallowedBar, 6));
        recipe.New(DayBreak, TileID.LunarCraftingStation, (FragmentSolar, 9));
        recipe.New(SolarEruption, TileID.LunarCraftingStation, (FragmentSolar, 9));
        recipe.New(ManaCrystal, TileID.Hellforge, (FallenStar, 4));
    }
}