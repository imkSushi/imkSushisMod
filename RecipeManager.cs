using System;
using imkSushisMod.Items;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using static Terraria.ID.TileID;
using static Terraria.ModLoader.ModContent;

namespace imkSushisMod
{
    public static class RecipeManager
    {
        public static void AddRecipes(Mod mod)
        {
            var recipe = new RecipeCreator(mod);
            AddExchangeRecipes(recipe);
            AddTaxedExchangeRecipes(recipe);
            AddMissingRecipes(recipe);
            AddDemonAltarRecipes(recipe);
            AddMeltingDownRecipes(recipe);
            AddDungeonChestRecipes(recipe);
            AddWeaponRecipes(recipe);
            AddWoodenChestRecipes(recipe);
            AddOtherPotionRecipes(recipe);
            AddSummoningPotionRecipes(recipe);
            recipe.StartNewRecipeSection("");
            
            if (RecipeCreator.FORMATRECIPES)
            {
                Console.WriteLine("Recipe file path please:");
                var path = Console.ReadLine();
                if (path != "")
                {
                    recipe.OutputRecipes(path);
                }
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

        //for armour, tax is a fifth of the cost of the item
        
        public static void AddTaxedExchangeRecipes(RecipeCreator recipe)
        {
            var mythrilAnvils = TileID.MythrilAnvil;
            recipe.StartNewRecipeSection("Taxed Exchanges");
            recipe.NewTaxed3Way(CobaltHat, CobaltHelmet, CobaltMask, (CobaltBar, 2), Anvils);
            recipe.NewTaxed3Way(PalladiumHeadgear, PalladiumHelmet, PalladiumMask, (PalladiumBar, 2), Anvils);
            recipe.NewTaxed3Way(MythrilHelmet, MythrilHat, MythrilHood, (MythrilBar, 2), mythrilAnvils);
            recipe.NewTaxed3Way(OrichalcumHelmet, OrichalcumMask, OrichalcumHeadgear, (OrichalcumBar, 2), mythrilAnvils);
            recipe.NewTaxed3Way(AdamantiteHeadgear, AdamantiteHelmet, AdamantiteMask, (AdamantiteBar, 2), mythrilAnvils);
            recipe.NewTaxed3Way(TitaniumHelmet, TitaniumHeadgear, TitaniumMask, (TitaniumBar, 2), mythrilAnvils);
            recipe.NewTaxed4Way(HallowedMask, HallowedHelmet, HallowedHeadgear, HallowedHood, (HallowedBar, 2), mythrilAnvils);
            recipe.NewTaxed4Way(AncientHallowedMask, AncientHallowedHelmet, AncientHallowedHeadgear, AncientHallowedHood, (HallowedBar, 2), mythrilAnvils);
            recipe.NewTaxed4Way(AncientHallowedMask, AncientHallowedHelmet, AncientHallowedHeadgear, AncientHallowedHood, (HallowedBar, 2), DemonAltar);
            recipe.NewTaxed3Way(ChlorophyteHeadgear, ChlorophyteHelmet, ChlorophyteMask, (ChlorophyteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(BeetleShell, BeetleScaleMail, BeetleHusk, mythrilAnvils);
            recipe.NewTaxed3Way(ShroomiteHeadgear, ShroomiteHelmet, ShroomiteMask, (ShroomiteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(SpectreHood, SpectreMask, (SpectreBar, 2), mythrilAnvils);
            
            recipe.NewTaxed2Way(CobaltPickaxe, CobaltDrill, (CobaltBar, 2), Anvils);
            recipe.NewTaxed2Way(PalladiumPickaxe, PalladiumDrill, (PalladiumBar, 2), Anvils);
            recipe.NewTaxed2Way(MythrilDrill, MythrilPickaxe, (MythrilBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(OrichalcumDrill, OrichalcumPickaxe, (OrichalcumBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(AdamantiteDrill, AdamantitePickaxe, (AdamantiteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(TitaniumDrill, TitaniumPickaxe, (TitaniumBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(ChlorophytePickaxe, ChlorophyteDrill, (ChlorophyteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(PickaxeAxe, Drax, (HallowedBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(VortexPickaxe, VortexDrill, (FragmentVortex, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(NebulaPickaxe, NebulaDrill, (FragmentNebula, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(StardustPickaxe, StardustDrill, (FragmentStardust, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(SolarFlarePickaxe, SolarFlareDrill, (FragmentSolar, 2), TileID.LunarCraftingStation);
            
            recipe.NewTaxed2Way(CobaltChainsaw, CobaltWaraxe, (CobaltBar, 2), Anvils);
            recipe.NewTaxed2Way(PalladiumChainsaw, PalladiumWaraxe, (PalladiumBar, 2), Anvils);
            recipe.NewTaxed2Way(MythrilChainsaw, MythrilWaraxe, (MythrilBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(OrichalcumChainsaw, OrichalcumWaraxe, (OrichalcumBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(AdamantiteChainsaw, AdamantiteWaraxe, (AdamantiteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(TitaniumChainsaw, TitaniumWaraxe, (TitaniumBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(ChlorophyteChainsaw, ChlorophyteGreataxe, (ChlorophyteBar, 2), mythrilAnvils);
            recipe.NewTaxed2Way(VortexChainsaw, VortexAxe, (FragmentVortex, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(NebulaChainsaw, NebulaAxe, (FragmentNebula, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(StardustChainsaw, StardustAxe, (FragmentStardust, 2), TileID.LunarCraftingStation);
            recipe.NewTaxed2Way(SolarFlareChainsaw, SolarFlareAxe, (FragmentSolar, 2), TileID.LunarCraftingStation);
            
        }

        public static void AddMissingRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Missing from Vanilla Recipes");
            recipe.New((DemoniteBar, 10), (ShadowScale, 5), Anvils, BallOHurt);
            recipe.New(Furnace, (HellstoneBar, 10), Anvils, ItemID.Hellforge);
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
            AddMelterCraftingRecipes(recipe);
            AddMeltingDownBarsRecipes(recipe);
            AddMeltingDownStaffsRecipes(recipe);
            AddMeltingDownSaberRecipes(recipe);
            AddMeltingDownAxesRecipes(recipe);
            AddMeltingDownHammersRecipes(recipe);
            MeltingDownGunsRecipes(recipe);
            AddMeltingDownSwordsRecipes(recipe);
            AddMeltingDownBowsRecipes(recipe);
            AddMeltingDownPickaxesRecipes(recipe);
            AddMeltingDownArmorRecipes(recipe);
            AddMeltingDownYoyosRecipes(recipe);
            AddMeltingDownFishingRodsRecipes(recipe);
            AddMeltingDownOthersRecipes(recipe);
        }

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
            
            recipe.StartNewRecipeSection("Melting Down Bows");
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
            recipe.New(MoltenFury, TileID.Hellforge, (HellstoneBar, 7));
        }
        
        public static void AddMeltingDownSwordsRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Swords");
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
            recipe.New(SwordWhip, melter, (HallowedBar, 6));
            recipe.New(Excalibur, melter, (HallowedBar, 6));
            recipe.New(Gungnir, melter, (HallowedBar, 6));
        }
        
        public static void AddMeltingDownArmorRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Armor");
            recipe.New(CopperHelmet, melter, (CopperBar, 6));
            recipe.New(CopperChainmail, melter, (CopperBar, 10));
            recipe.New(CopperGreaves, melter, (CopperBar, 8));
            recipe.New(TinHelmet, melter, (TinBar, 6));
            recipe.New(TinChainmail, melter, (TinBar, 10));
            recipe.New(TinGreaves, melter, (TinBar, 8));
            recipe.New(IronHelmet, melter, (IronBar, 7));
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
        }
        
        public static void AddMeltingDownHammersRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Hammers");
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
        }

        public static void MeltingDownGunsRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Guns");
            recipe.New(SpaceGun, melter, (MeteoriteBar, 10));
            recipe.New(StarCannon, melter, (MeteoriteBar, 10));
            recipe.New(PhoenixBlaster, hellmelter, (HellstoneBar, 5));
        }

        public static void AddMeltingDownPickaxesRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Pickaxes");
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
        }

        public static void AddMeltingDownYoyosRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Yoyos");
            recipe.New(CorruptYoyo, melter, (DemoniteBar, 6));
            recipe.New(CrimsonYoyo, melter, (DemoniteBar, 6));
        }

        public static void AddMeltingDownFishingRodsRecipes(RecipeCreator recipe)
        {
            var melter = TileType<Tiles.Melter>();
            var hellmelter = TileType<Tiles.Hellmelter>();
            var adamantitemelter = TileType<Tiles.AdamantiteMelter>();
            
            recipe.StartNewRecipeSection("Melting Down Fishing Rods");
            recipe.New(FisherofSouls, melter, (DemoniteBar, 4));
            recipe.New(Fleshcatcher, melter, (CrimtaneBar, 4));
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
            recipe.New(TheMeatball, melter, (CrimtaneBar, 5));
            recipe.New(TheMeatball, melter, (TissueSample, 2));
            recipe.New(BallOHurt, melter, (DemoniteBar, 5));
            recipe.New(BallOHurt, melter, (ShadowScale, 2));
            recipe.New(MeteorStaff, melter, (MeteoriteBar, 10));
            recipe.New(FireproofBugNet, hellmelter, (HellstoneBar, 7));
            recipe.New(Flamarang, hellmelter, (HellstoneBar, 5));
            recipe.New((HellfireArrow, 150), hellmelter, HellstoneBar);
            recipe.New(ImpStaff, hellmelter, (HellstoneBar, 8));
        }

        public static void AddOtherPotionRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Other Potions");
            recipe.New(BottledWater, Daybloom, Deathweed, Gravestone, Bottles, ItemType<ResurrectionPotion>());
            recipe.New(BottledWater, (MeteoriteBar, 10), Bottles, ItemType<MeteoritePotion>());
            recipe.New(BottledWater, Deathweed, Waterleaf, Bass, Bottles, ItemType<AnglerAmnesiaPotion>());
        }

        public static void AddSummoningPotionRecipes(RecipeCreator recipe)
        {
            var basePotion = ItemType<BaseSummoningPotion>();
            
            recipe.StartNewRecipeSection("Summoning Potions");
            recipe.New(BottledWater, Daybloom, Moonglow, LavaBucket, Bottles, basePotion);
            recipe.New(basePotion, (Bass, 10), Bottles, ItemType<AnglerSummoningPotion>());
            recipe.New(basePotion, (MusketBall, 75), Bottles, ItemType<ArmsDealerSummoningPotion>());
            recipe.New(basePotion, (Ale, 5), Bottles, ItemType<BartenderSummoningPotion>());
            recipe.New(basePotion, GoldenKey, Bottles, ItemType<ClothierSummoningPotion>());
            recipe.New(basePotion, (Nanites, 10), Bottles, ItemType<CyborgSummoningPotion>());
            recipe.New(basePotion, (Bomb, 25), Bottles, ItemType<DemolitionistSummoningPotion>());
            recipe.New(basePotion, (ShadowScale, 2), Bottles, ItemType<DryadSummoningPotion>());
            recipe.New(basePotion, (TissueSample, 2), Bottles, ItemType<DryadSummoningPotion>());
            recipe.New(basePotion, StrangePlant1, Bottles, ItemType<DyeTraderSummoningPotion>());
            recipe.New(basePotion, StrangePlant2, Bottles, ItemType<DyeTraderSummoningPotion>());
            recipe.New(basePotion, StrangePlant3, Bottles, ItemType<DyeTraderSummoningPotion>());
            recipe.New(basePotion, StrangePlant4, Bottles, ItemType<DyeTraderSummoningPotion>());
            recipe.New(basePotion, (SpikyBall, 25), Bottles, ItemType<GoblinTinkererSummoningPotion>());
            recipe.New(basePotion, GolfBall, Bottles, ItemType<GolferSummoningPotion>());
            recipe.New(basePotion, GuideVoodooDoll, Bottles, ItemType<GuideSummoningPotion>());
            recipe.New(basePotion, (Wire, 20), Bottles, ItemType<MechanicSummoningPotion>());
            recipe.New(basePotion, (SilverCoin, 50), Bottles, ItemType<MerchantSummoningPotion>());
            recipe.New(basePotion, LesserHealingPotion, Bottles, ItemType<NurseSummoningPotion>());
            recipe.New(basePotion, (Wood, 28), Bottles, ItemType<PainterSummoningPotion>());
            recipe.New(basePotion, (ItemID.Confetti, 10), Bottles, ItemType<PartyGirlSummoningPotion>());
            recipe.New(basePotion, PirateMap, Bottles, ItemType<PirateSummoningPotion>());
            recipe.New(basePotion, GlassSlipper, Bottles, ItemType<PrincessSummoningPotion>());
            recipe.New(basePotion, Present, Bottles, ItemType<SantaClausSummoningPotion>());
            recipe.New(basePotion, (HallowedBar, 2), Bottles, ItemType<SteampunkerSummoningPotion>());
            recipe.New(basePotion, (ItemID.Cobweb, 30), Bottles, ItemType<StylistSummoningPotion>());
            recipe.New(basePotion, (GoldCoin, 10), PurificationPowder, Bottles, ItemType<TaxCollectorSummoningPotion>());
            recipe.New(basePotion, (GlowingMushroom, 100), Bottles, ItemType<TruffleSummoningPotion>());
            recipe.New(basePotion, (ItemID.RichMahogany, 10), Bottles, ItemType<WitchDoctorSummoningPotion>());
            recipe.New(basePotion, GreaterManaPotion, Bottles, ItemType<WizardSummoningPotion>());
            recipe.New(basePotion, Bunny, Penguin, Squirrel, Goldfish, Bottles, ItemType<ZoologistSummoningPotion>());
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