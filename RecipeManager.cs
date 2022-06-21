using System;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using static Terraria.ID.TileID;

namespace imkSushisMod
{
    public static class RecipeManager
    {
        public static void AddRecipes(Mod mod)
        {
            var recipe = new RecipeCreator(mod);
            AddExchangeRecipes(recipe);
            AddDemonAltarRecipes(recipe);
            AddMeltingDownRecipes(recipe);
            AddDungeonChestRecipes(recipe);
            AddWeaponRecipes(recipe);
            AddWoodenChestRecipes(recipe);
            
            if (RecipeCreator.FORMATRECIPES)
            {
                Console.WriteLine("Recipe file path please:");
                recipe.OutputRecipes(Console.ReadLine());
            }
        }

        public static void AddExchangeRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Bars");
            recipe.New2Way(CopperBar, TinBar, TinkerersWorkbench);
            recipe.New2Way(IronBar, LeadBar, TinkerersWorkbench);
            recipe.New2Way(SilverBar, TungstenBar, TinkerersWorkbench);
            recipe.New2Way(GoldBar, PlatinumBar, TinkerersWorkbench);
            recipe.New2Way(DemoniteBar, CrimtaneBar, TinkerersWorkbench);
            recipe.New2Way(CobaltBar, PalladiumBar, TinkerersWorkbench);
            recipe.New2Way(MythrilBar, OrichalcumBar, TinkerersWorkbench);
            recipe.New2Way(AdamantiteBar, TitaniumBar, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Ores");
            recipe.New2Way(CopperOre, TinOre, TinkerersWorkbench);
            recipe.New2Way(IronOre, LeadOre, TinkerersWorkbench);
            recipe.New2Way(SilverOre, TungstenOre, TinkerersWorkbench);
            recipe.New2Way(GoldOre, PlatinumOre, TinkerersWorkbench);
            recipe.New2Way(DemoniteOre, CrimtaneOre, TinkerersWorkbench);
            recipe.New2Way(CobaltOre, PalladiumOre, TinkerersWorkbench);
            recipe.New2Way(MythrilOre, OrichalcumOre, TinkerersWorkbench);
            recipe.New2Way(AdamantiteOre, TitaniumOre, TinkerersWorkbench);

            recipe.StartNewRecipeSection("Materials");
            recipe.New2Way(CursedFlame, Ichor, TinkerersWorkbench);
            recipe.New2Way(TissueSample, ShadowScale, TinkerersWorkbench);
            recipe.New2Way(Vertebrae, RottenChunk, TinkerersWorkbench);
            recipe.New2Way(BoneRattle, EatersBone, TinkerersWorkbench);
            recipe.New2Way(CrimsonSeeds, CorruptSeeds, TinkerersWorkbench);
            recipe.New2Way(CrimsonKey, CorruptionKey, TinkerersWorkbench);
            recipe.New2Way(CrimstoneBlock, EbonstoneBlock, TinkerersWorkbench);
            recipe.New2Way(ViciousMushroom, VileMushroom,TinkerersWorkbench);
            recipe.New2Way(ItemID.Ebonwood, ItemID.Shadewood, TinkerersWorkbench);
            recipe.New2Way(WormScarf, BrainOfConfusion, TinkerersWorkbench);
            
            
            recipe.StartNewRecipeSection("Orb & Heart Drops");
            recipe.New2Way(Musket, TheUndertaker, TinkerersWorkbench);
            recipe.New2Way(ShadowOrb, CrimsonHeart, TinkerersWorkbench);
            recipe.New2Way(Vilethorn, CrimsonRod, TinkerersWorkbench);
            recipe.New2Way(BallOHurt, TheRottedFork, TinkerersWorkbench);
            recipe.New2Way(BandofStarpower, PanicNecklace, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Woods");
            recipe.New2Way(ItemID.Ebonwood, ItemID.Shadewood, TinkerersWorkbench);
            recipe.New3Way(ItemID.PalmWood, ItemID.RichMahogany, ItemID.BorealWood, TinkerersWorkbench);
        }

        public static void AddDemonAltarRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Demon Altar Recipes");
            recipe.New((ViciousPowder, 30), (Vertebrae, 15), TileID.MythrilAnvil, BloodySpine);
            recipe.New((VilePowder, 30), (RottenChunk, 15), TileID.MythrilAnvil, WormFood);
            recipe.New((FlinxFur, 3), (CrimtaneOre, 5), Lens, TileID.MythrilAnvil, DeerThing);
            recipe.New((FlinxFur, 3), (DemoniteOre, 5), Lens, TileID.MythrilAnvil, DeerThing);
            recipe.New(LightsBane, Muramasa, BladeofGrass, FieryGreatsword, TileID.MythrilAnvil, NightsEdge);
            recipe.New(BloodButcherer, Muramasa, BladeofGrass, FieryGreatsword, TileID.MythrilAnvil, NightsEdge);
            recipe.New((Gel, 20), PlatinumCrown, TileID.MythrilAnvil, SlimeCrown);
            recipe.New((Gel, 20), GoldCrown, TileID.MythrilAnvil, SlimeCrown);
            recipe.New((Lens, 6), TileID.MythrilAnvil, SuspiciousLookingEye);
            recipe.New((Bone, 30), (JungleSpores, 15), (ShadowScale, 30), TileID.MythrilAnvil, VoidLens);
            recipe.New((Bone, 30), (JungleSpores, 15), (TissueSample, 30), TileID.MythrilAnvil, VoidLens);
            recipe.New((Bone, 15), (JungleSpores, 8), (ShadowScale, 15), TileID.MythrilAnvil, ItemID.VoidVault);
            recipe.New((Bone, 15), (JungleSpores, 8), (TissueSample, 15), TileID.MythrilAnvil, ItemID.VoidVault);
            
            recipe.New((DemoniteBar, 20), (ShadowScale, 15), DemonAltar, AncientShadowGreaves);
            recipe.New((DemoniteBar, 25), (ShadowScale, 20), DemonAltar, AncientShadowScalemail);
            recipe.New((DemoniteBar, 15), (ShadowScale, 10), DemonAltar, AncientShadowHelmet);
            recipe.New((CobaltBar, 20), DemonAltar, CobaltBreastplate);
            recipe.New((CobaltBar, 10), DemonAltar, CobaltHat);
            recipe.New((CobaltBar, 10), DemonAltar, CobaltHelmet);
            recipe.New((CobaltBar, 15), DemonAltar, CobaltLeggings);
            recipe.New((CobaltBar, 10), DemonAltar, CobaltMask);
            recipe.New((IronBar, 15), DemonAltar, AncientIronHelmet);
            recipe.New((GoldBar, 20), DemonAltar, AncientGoldHelmet);
            recipe.New((Bone, 40), (ItemID.Cobweb, 40), DemonAltar, AncientNecroHelmet);
        }

        public static void AddDungeonChestRecipes(RecipeCreator recipe)
        {
            var mythrilAnvil = TileID.MythrilAnvil;
            recipe.StartNewRecipeSection("Dungeon Chest");
            recipe.New(CorruptionChest, CorruptionKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, ScourgeoftheCorruptor);
            recipe.New(CrimsonChest, CrimsonKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, VampireKnives);
            recipe.New(JungleChest, JungleKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, PiranhaGun);
            recipe.New(HallowedChest, HallowedKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, RainbowGun);
            recipe.New(FrozenChest, FrozenKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, StaffoftheFrostHydra);
            recipe.New(DungeonDesertChest, DungeonDesertKey, (SoulofFright, 5), (SoulofMight, 5), (SoulofSight, 5), mythrilAnvil, StormTigerStaff);
            
            recipe.New((EbonwoodChest, 5), TempleKey, (SpectreBar, 10), (DemoniteBar, 12), TileID.HeavyWorkBench, CorruptionChest);
            recipe.New((ShadewoodChest, 5), TempleKey, (SpectreBar, 10), (CrimtaneBar, 12), TileID.HeavyWorkBench, CrimsonChest);
            recipe.New((RichMahoganyChest, 5), TempleKey, (SpectreBar, 10), (ChlorophyteBar, 4), TileID.HeavyWorkBench, JungleChest);
            recipe.New((PearlwoodChest, 5), TempleKey, (SpectreBar, 10), (HallowedBar, 9), TileID.HeavyWorkBench, HallowedChest);
            recipe.New((BorealWoodChest, 5), TempleKey, (SpectreBar, 10), (FrostCore, 2), TileID.HeavyWorkBench, FrozenChest);
            recipe.New((DesertChest, 5), TempleKey, (SpectreBar, 10), (HellstoneBar, 9), TileID.HeavyWorkBench, DungeonDesertChest);
        }

        public static void AddMeltingDownRecipes(RecipeCreator recipe)
        {
            AddMeltingDownBarsRecipes(recipe);
            AddMeltingDownStaffsRecipes(recipe);
            AddMeltingDownAxesRecipes(recipe);
            AddMeltingDownHammersRecipes(recipe);
            AddMeltingDownSwordsRecipes(recipe);
            AddMeltingDownBowsRecipes(recipe);
            AddMeltingDownPickaxesRecipes(recipe);
            AddMeltingDownArmorRecipes(recipe);
            AddMeltingDownOthersRecipes(recipe);
        }

        public static void AddMeltingDownBarsRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Bars");
            recipe.New(CopperBar, Furnaces, (CopperOre, 2));
            recipe.New(TinBar, Furnaces, (TinOre, 2));
            recipe.New(IronBar, Furnaces, (IronOre, 2));
            recipe.New(LeadBar, Furnaces, (LeadOre, 2));
            recipe.New(SilverBar, Furnaces, (SilverOre, 3));
            recipe.New(TungstenBar, Furnaces, (TungstenOre, 3));
            recipe.New(GoldBar, Furnaces, (GoldOre, 3));
            recipe.New(PlatinumBar, Furnaces, (PlatinumOre, 3));
            recipe.New(DemoniteBar, Furnaces, (DemoniteOre, 2));
            recipe.New(CrimtaneBar, Furnaces, (CrimtaneOre, 2));
            recipe.New(MeteoriteBar, Furnaces, (ItemID.Meteorite, 2));
            recipe.New(HellstoneBar, TileID.Hellforge, (ItemID.Hellstone, 2));
            recipe.New(HellstoneBar, TileID.Hellforge, ItemID.Obsidian);
            recipe.New(CobaltBar, Furnaces, (CobaltOre, 2));
            recipe.New(PalladiumBar, Furnaces, (PalladiumOre, 2));
            recipe.New(MythrilBar, Furnaces, (MythrilOre, 3));
            recipe.New(OrichalcumBar, Furnaces, (OrichalcumOre, 3));
            recipe.New(AdamantiteBar, TileID.AdamantiteForge, (AdamantiteOre, 3));
            recipe.New(TitaniumBar, TileID.AdamantiteForge, (TitaniumOre, 3));
            recipe.New(ChlorophyteBar, TileID.AdamantiteForge, (ChlorophyteOre, 4));
            recipe.New(LunarBar, TileID.LunarCraftingStation, (ItemID.LunarOre, 3));
            recipe.New((SpectreBar, 3), TileID.AdamantiteForge, Ectoplasm);
            recipe.New((SpectreBar, 3), TileID.AdamantiteForge, (ChlorophyteBar, 2));
            recipe.New((ShroomiteBar, 3), TileID.Autohammer, (ChlorophyteBar, 2));
            recipe.New(ShroomiteBar, TileID.Autohammer, (GlowingMushroom, 10));
        }

        public static void AddMeltingDownStaffsRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Staffs");
            recipe.New(AmethystStaff, Furnaces, (ItemID.Amethyst, 4));
            recipe.New(AmethystStaff, Furnaces, (CopperBar, 5));
            recipe.New(TopazStaff, Furnaces, (ItemID.Topaz, 4));
            recipe.New(TopazStaff, Furnaces, (TinBar, 5));
            recipe.New(SapphireStaff, Furnaces, (ItemID.Sapphire, 4));
            recipe.New(SapphireStaff, Furnaces, (SilverBar, 5));
            recipe.New(EmeraldStaff, Furnaces, (ItemID.Emerald, 4));
            recipe.New(EmeraldStaff, Furnaces, (TungstenBar, 5));
            recipe.New(RubyStaff, Furnaces, (ItemID.Ruby, 4));
            recipe.New(RubyStaff, Furnaces, (GoldBar, 5));
            recipe.New(DiamondStaff, Furnaces, (ItemID.Diamond, 4));
            recipe.New(DiamondStaff, Furnaces, (PlatinumBar, 5));
            recipe.New(AmberStaff, Furnaces, (Amber, 4));
            recipe.New(AmberStaff, Furnaces, (ItemID.FossilOre, 7));
        }

        public static void AddMeltingDownAxesRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Axes");
            recipe.New(CopperAxe, Furnaces, (CopperBar, 3));
            recipe.New(TinAxe, Furnaces, (TinBar, 3));
            recipe.New(IronAxe, Furnaces, (IronBar, 4));
            recipe.New(LeadAxe, Furnaces, (LeadBar, 4));
        }
        
        public static void AddMeltingDownBowsRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Bows");
            recipe.New(CopperBow, Furnaces, (CopperBar, 3));
            recipe.New(TinBow, Furnaces, (TinBar, 3));
            recipe.New(IronBow, Furnaces, (IronBar, 3));
            recipe.New(LeadBow, Furnaces, (LeadBar, 3));
        }
        
        public static void AddMeltingDownSwordsRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Swords");
            recipe.New(CopperShortsword, Furnaces, (CopperBar, 2));
            recipe.New(CopperBroadsword, Furnaces, (CopperBar, 3)); 
            recipe.New(TinShortsword, Furnaces, (TinBar, 2));
            recipe.New(TinBroadsword, Furnaces, (TinBar, 3));
            recipe.New(IronShortsword, Furnaces, (IronBar, 3));
            recipe.New(IronBroadsword, Furnaces, (IronBar, 4));
            recipe.New(LeadShortsword, Furnaces, (LeadBar, 3));
            recipe.New(LeadBroadsword, Furnaces, (LeadBar, 4));
        }
        
        public static void AddMeltingDownArmorRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Armor");
            recipe.New(CopperHelmet, Furnaces, (CopperBar, 6));
            recipe.New(CopperChainmail, Furnaces, (CopperBar, 10));
            recipe.New(CopperGreaves, Furnaces, (CopperBar, 8));
            recipe.New(TinHelmet, Furnaces, (TinBar, 6));
            recipe.New(TinChainmail, Furnaces, (TinBar, 10));
            recipe.New(TinGreaves, Furnaces, (TinBar, 8));
            recipe.New(IronHelmet, Furnaces, (IronBar, 7));
            recipe.New(IronChainmail, Furnaces, (IronBar, 12));
            recipe.New(IronGreaves, Furnaces, (IronBar, 10));
            recipe.New(LeadHelmet, Furnaces, (LeadBar, 7));
            recipe.New(LeadChainmail, Furnaces, (LeadBar, 12));
            recipe.New(LeadGreaves, Furnaces, (LeadBar, 10));
        }
        
        public static void AddMeltingDownHammersRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Hammers");
            recipe.New(CopperHammer, Furnaces, (CopperBar, 4));
            recipe.New(TinHammer, Furnaces, (TinBar, 4));
            recipe.New(IronHammer, Furnaces, (IronBar, 4));
            recipe.New(LeadHammer, Furnaces, (LeadBar, 4));
        }
        
        public static void AddMeltingDownPickaxesRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Pickaxes");
            recipe.New(CopperPickaxe, Furnaces, (CopperBar, 4));
            recipe.New(TinPickaxe, Furnaces, (TinBar, 4));
            recipe.New(IronPickaxe, Furnaces, (IronBar, 5));
            recipe.New(LeadPickaxe, Furnaces, (LeadBar, 5));
        }
        
        //chests, chandeliers, doors, clocks, furniture, crafting stations etc.
        
        public static void AddMeltingDownOthersRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Melting Down Others");
            recipe.New(CopperWatch, Furnaces, (CopperBar, 5));
            recipe.New(TinWatch, Furnaces, (TinBar, 5));
            recipe.New(GravediggerShovel, Furnaces, (IronBar, 6));
            recipe.New(GravediggerShovel, Furnaces, (LeadBar, 6));
        }

        public static void AddWeaponRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Weapons");
            recipe.NewG(RecipeGroupID.IronBar, WorkBenches, (ThrowingKnife, 25));
            recipe.NewGn(RecipeGroupID.IronBar, ItemID.Chain, WorkBenches, (Shuriken, 50));
        }

        public static void AddWoodenChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Wooden Chest Loot");
            //recipe.New();
        }
    }
}