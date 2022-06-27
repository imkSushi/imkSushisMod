using System;
using imkSushisMod.Items;
using Terraria.ID;
using static imkSushisMod.imkSushiRecipeGroups;
using static Terraria.ID.ItemID;
using static Terraria.ID.TileID;
using static Terraria.ModLoader.ModContent;
using static imkSushisMod.MeltingRecipes;

namespace imkSushisMod
{
    [GenerateRecipes]
    public static class RecipeManager
    {
        public static void AddRecipes()
        {
            var recipe = new RecipeCreator();
            AddExchangeRecipes(recipe);
            AddTaxedExchangeRecipes(recipe);
            AddMissingRecipes(recipe);
            AddDemonAltarRecipes(recipe);
            AddMeltingDownRecipes(recipe);
            AddDungeonChestRecipes(recipe);
            AddWoodenChestRecipes(recipe);
            AddOtherPotionRecipes(recipe);
            AddSummoningPotionRecipes(recipe);
            AddBiomeKeyRecipes(recipe);
            AddStatueRecipes(recipe);
            AddItemRecipes(recipe);
            AddGoldChestRecipes(recipe);
            AddPyramidChestRecipes(recipe);
            AddFrozenChestRecipes(recipe);
            AddLihzahrdChestRecipes(recipe);
            AddLivingWoodChestRecipes(recipe);
            AddWebbedChestRecipes(recipe);
            AddSanstoneChestRecipes(recipe);
            AddMushroomChestRecipes(recipe);
            AddMinecartRecipes(recipe);
            AddTrapsRecipes(recipe);
            AddUntrapChestRecipes(recipe);
            
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
            recipe.StartNewRecipeSection("Bars Exchange Recipes");
            recipe.New2Way(CopperBar, TinBar, TinkerersWorkbench);
            recipe.New2Way(IronBar, LeadBar, TinkerersWorkbench);
            recipe.New2Way(SilverBar, TungstenBar, TinkerersWorkbench);
            recipe.New2Way(GoldBar, PlatinumBar, TinkerersWorkbench);
            recipe.New2Way(DemoniteBar, CrimtaneBar, TinkerersWorkbench);
            recipe.New2Way(CobaltBar, PalladiumBar, TinkerersWorkbench);
            recipe.New2Way(MythrilBar, OrichalcumBar, TinkerersWorkbench);
            recipe.New2Way(AdamantiteBar, TitaniumBar, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Ores Exchange Recipes");
            recipe.New2Way(CopperOre, TinOre, TinkerersWorkbench);
            recipe.New2Way(IronOre, LeadOre, TinkerersWorkbench);
            recipe.New2Way(SilverOre, TungstenOre, TinkerersWorkbench);
            recipe.New2Way(GoldOre, PlatinumOre, TinkerersWorkbench);
            recipe.New2Way(DemoniteOre, CrimtaneOre, TinkerersWorkbench);
            recipe.New2Way(CobaltOre, PalladiumOre, TinkerersWorkbench);
            recipe.New2Way(MythrilOre, OrichalcumOre, TinkerersWorkbench);
            recipe.New2Way(AdamantiteOre, TitaniumOre, TinkerersWorkbench);

            recipe.StartNewRecipeSection("Materials Exchange Recipes");
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
            
            
            recipe.StartNewRecipeSection("Orb & Heart Drops Exchange Recipes");
            recipe.New2Way(Musket, TheUndertaker, TinkerersWorkbench);
            recipe.New2Way(ShadowOrb, CrimsonHeart, TinkerersWorkbench);
            recipe.New2Way(Vilethorn, CrimsonRod, TinkerersWorkbench);
            recipe.New2Way(BallOHurt, TheRottedFork, TinkerersWorkbench);
            recipe.New2Way(BandofStarpower, PanicNecklace, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Woods Exchange Recipes");
            recipe.New3Way(ItemID.PalmWood, ItemID.RichMahogany, ItemID.BorealWood, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Mimic Drops Exchange Recipes");
            recipe.New2Way(DartPistol, DartRifle, TinkerersWorkbench);
            recipe.New2Way(WormHook, TendonHook, TinkerersWorkbench);
            recipe.New2Way(ChainGuillotines, FetidBaghnakhs, TinkerersWorkbench);
            recipe.New2Way(ClingerStaff, SoulDrain, TinkerersWorkbench);
            recipe.New2Way(PutridScent, FleshKnuckles, TinkerersWorkbench);
            
            recipe.StartNewRecipeSection("Other Exchange Recipes");
            recipe.New2Way(SilverBullet, TungstenBullet, TinkerersWorkbench);
        }

        //for armour, tax is a fifth of the cost of the item
        
        public static void AddTaxedExchangeRecipes(RecipeCreator recipe)
        {
            var mythrilAnvils = TileID.MythrilAnvil;
            recipe.StartNewRecipeSection("Taxed Exchanges Recipes");
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
            
            recipe.NewTaxed2Way(ChlorophyteWarhammer, ChlorophyteJackhammer, (ChlorophyteBar, 2), mythrilAnvils);
        }

        public static void AddMissingRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Missing from Vanilla Recipes");
            recipe.New((DemoniteBar, 10), (ShadowScale, 5), Anvils, BallOHurt);
            recipe.New(Furnace, (HellstoneBar, 10), Anvils, ItemID.Hellforge);
            recipe.New((HallowedBar, 18), TileID.MythrilAnvil, Pwnhammer);
            recipe.New(EnchantedBoomerang, GoldBroadsword, DemonAltar, EnchantedSword);
            recipe.New(EnchantedBoomerang, PlatinumBroadsword, DemonAltar, EnchantedSword);
            recipe.New(EnchantedBoomerang, GoldBroadsword, TileID.MythrilAnvil, EnchantedSword);
            recipe.New(EnchantedBoomerang, PlatinumBroadsword, TileID.MythrilAnvil, EnchantedSword);
            recipe.NewNg(EnchantedSword, (GoldBars, 10), DemonAltar, Terragrim);
            recipe.NewNg(EnchantedSword, (GoldBars, 10), TileID.MythrilAnvil, Terragrim);
            recipe.NewNg((ItemID.GoldBrick, 8), (RecipeGroupID.IronBar, 2), WorkBenches, GoldenChest);
            recipe.NewNg((MudstoneBlock, 8), (RecipeGroupID.IronBar, 2), WorkBenches, IvyChest);
            recipe.NewNg((CoralstoneBlock, 8), (RecipeGroupID.IronBar, 2), WorkBenches, WaterChest);
            recipe.NewNg((SpiderBlock, 8), (RecipeGroupID.IronBar, 2), WorkBenches, WebCoveredChest);
            recipe.NewNg((ItemID.DemoniteBrick, 8), (RecipeGroupID.IronBar, 2), WorkBenches, ShadowChest);
            recipe.NewNg((ItemID.CrimtaneBrick, 8), (RecipeGroupID.IronBar, 2), WorkBenches, ShadowChest);
            recipe.New(GuideVoodooDoll, RedHat, DemonAltar, ClothierVoodooDoll);
            recipe.New(GuideVoodooDoll, RedHat, TileID.MythrilAnvil, ClothierVoodooDoll);
            recipe.New((Silk, 3), TileID.Loom, RedHat);
        }

        public static void AddItemRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Item Recipes");
            recipe.New(HealingPotion, JungleRose, TinkerersWorkbench, ItemType<HealingFlower>());
            recipe.New(ItemType<HealingFlower>(), ManaFlower, TinkerersWorkbench, ItemType<FeederFlower>());
        }

        public static void AddDemonAltarRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Demon Altar Recipes");
            recipe.New((ViciousPowder, 30), (Vertebrae, 15), TileID.MythrilAnvil, BloodySpine);
            recipe.New((VilePowder, 30), (RottenChunk, 15), TileID.MythrilAnvil, WormFood);
            recipe.New((FlinxFur, 3), Lens, (CrimtaneOre, 5), TileID.MythrilAnvil, DeerThing);
            recipe.New((FlinxFur, 3), Lens, (DemoniteOre, 5), TileID.MythrilAnvil, DeerThing);
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
            recipe.StartNewRecipeSection("Dungeon Chest Recipes");
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
            recipe.New((BorealWoodChest, 5), TempleKey, (SpectreBar, 10), (FrostCore, 1), TileID.HeavyWorkBench, FrozenChest);
            recipe.New((DesertChest, 5), TempleKey, (SpectreBar, 10), (HellstoneBar, 9), TileID.HeavyWorkBench, DungeonDesertChest);
        }

        public static void AddBiomeKeyRecipes(RecipeCreator recipe)
        {
            var biomeKey = ItemType<BiomeKey>();
            
            recipe.StartNewRecipeSection("Biome Key Recipes");
            recipe.New(CorruptionKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            recipe.New(CrimsonKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            recipe.New(JungleKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            recipe.New(HallowedKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            recipe.New(FrozenKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            recipe.New(DungeonDesertKey, (GreenSolution, 10), TinkerersWorkbench, biomeKey);
            
            recipe.New(biomeKey, (DemoniteBar, 48), TinkerersWorkbench, CorruptionKey);
            recipe.New(biomeKey, (CrimtaneBar, 48), TinkerersWorkbench, CrimsonKey);
            recipe.New(biomeKey, (ChlorophyteBar, 16), TinkerersWorkbench, JungleKey);
            recipe.New(biomeKey, (HallowedBar, 36), TinkerersWorkbench, HallowedKey);
            recipe.New(biomeKey, (FrostCore, 2), TinkerersWorkbench, FrozenKey);
            recipe.New(biomeKey, (HellstoneBar, 36), TinkerersWorkbench, DungeonDesertKey);
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
            AddMeltingDownSpearsRecipes(recipe);
            AddMeltingDownHooksRecipes(recipe);
            AddMeltingDownBooksRecipes(recipe);
            AddMeltingDownSummoningWeapons(recipe);
            AddMeltingDownFlailsRecipes(recipe);
        }

        public static void AddOtherPotionRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Other Potions Recipes");
            recipe.New(BottledWater, Daybloom, Deathweed, Gravestone, Bottles, ItemType<ResurrectionPotion>());
            recipe.New(BottledWater, (MeteoriteBar, 10), Bottles, ItemType<MeteoritePotion>());
            recipe.New(BottledWater, Deathweed, Waterleaf, Bass, Bottles, ItemType<AnglerAmnesiaPotion>());
        }

        public static void AddSummoningPotionRecipes(RecipeCreator recipe)
        {
            var basePotion = ItemType<BaseSummoningPotion>();
            
            recipe.StartNewRecipeSection("Summoning Potions Recipes");
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

        public static void AddStatueRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Statues Recipes");
            void AddStatueRecipe(int statue, int banner)
            {
                recipe.New(banner, (StoneBlock, 100), TileID.HeavyWorkBench, statue);
            }
            
            AddStatueRecipe(ZombieArmStatue, ZombieBanner);
            AddStatueRecipe(BatStatue, BatBanner);
            AddStatueRecipe(BloodZombieStatue, BloodZombieBanner);
            AddStatueRecipe(BoneSkeletonStatue, SkeletonBanner);
            AddStatueRecipe(ChestStatue, MimicBanner);
            AddStatueRecipe(CorruptStatue, EaterofSoulsBanner);
            AddStatueRecipe(CrabStatue, CrabBanner);
            AddStatueRecipe(DripplerStatue, DripplerBanner);
            AddStatueRecipe(EyeballStatue, DemonEyeBanner);
            AddStatueRecipe(GoblinStatue, GoblinScoutBanner);
            AddStatueRecipe(GraniteGolemStatue, GraniteGolemBanner);
            AddStatueRecipe(HarpyStatue, HarpyBanner);
            AddStatueRecipe(HopliteStatue, GreekSkeletonBanner);
            AddStatueRecipe(HornetStatue, HornetBanner);
            AddStatueRecipe(ImpStatue, FireImpBanner);
            AddStatueRecipe(JellyfishStatue, JellyfishBanner);
            AddStatueRecipe(MedusaStatue, MedusaBanner);
            AddStatueRecipe(PigronStatue, PigronBanner);
            AddStatueRecipe(PiranhaStatue, PiranhaBanner);
            AddStatueRecipe(SharkStatue, SharkBanner);
            AddStatueRecipe(SkeletonStatue, SkeletonBanner);
            AddStatueRecipe(SlimeStatue, SlimeBanner);
            AddStatueRecipe(UndeadVikingStatue, UndeadVikingBanner);
            AddStatueRecipe(UnicornStatue, UnicornBanner);
            AddStatueRecipe(WallCreeperStatue, SpiderBanner);
            AddStatueRecipe(WraithStatue, WraithBanner);
            
            recipe.New((StoneBlock, 100), SoulofNight, TileID.HeavyWorkBench, KingStatue);
            recipe.New((StoneBlock, 100), SoulofLight, TileID.HeavyWorkBench, QueenStatue);
            recipe.New((StoneBlock, 100), (Bomb, 25), TileID.HeavyWorkBench, BombStatue);
            recipe.New((StoneBlock, 100), LifeCrystal, TileID.HeavyWorkBench, HeartStatue);
            recipe.New((StoneBlock, 100), ManaCrystal, TileID.HeavyWorkBench, StarStatue);
        }

        public static void AddMinecartRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Minecarts Recipes");
            recipe.New(Minecart, (ItemID.FossilOre, 2), Anvils, DesertMinecart);
            recipe.New(Minecart, (BeeWax, 2), Anvils, BeeMinecart);
            recipe.New(Minecart, (LadyBug, 3), Anvils, LadybugMinecart);
            recipe.New(Minecart, (ItemID.Sunflower, 3), Anvils, SunflowerMinecart);
            recipe.New(Minecart, LavaCharm, Anvils, HellMinecart);
            recipe.New(Minecart, (GlowingMushroom, 25), Anvils, ShroomMinecart);
            
            recipe.NewNg(DesertMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(FishMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(BeeMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(LadybugMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(PigronMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(SunflowerMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(ShroomMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(AmethystMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(TopazMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(SapphireMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(EmeraldMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(RubyMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(DiamondMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(AmberMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(BeetleMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(MeowmereMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(PartyMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(PirateMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(SteampunkMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
            recipe.NewNg(CoffinMinecart, (RecipeGroupID.IronBar, 2), TinkerersWorkbench, Minecart);
        }

        public static void AddWoodenChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Wooden Chest Loot Recipes");
            recipe.NewG((CopperBars, 8), Anvils, Spear);
            recipe.NewNg((Wood, 20), RecipeGroupID.IronBar, WorkBench, WoodenBoomerang);
            recipe.NewNg((Wood, 10), RecipeGroupID.IronBar, WorkBenches, WandofSparking);
            recipe.New((Wood, 10), WorkBenches, PortableStool);
        }

        public static void AddGoldChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Gold Chest Loot Recipes");
            recipe.New(ItemID.LifeCrystal, ItemID.Chain, TinkerersWorkbench, BandofRegeneration);
            recipe.NewG((RecipeGroupID.IronBar, 5), ManaCrystal, TinkerersWorkbench, MagicMirror);
            recipe.New(ItemID.Bottle, (ItemID.Cloud, 25), TinkerersWorkbench, CloudinaBottle);
            recipe.New(Feather, (Silk, 10), TinkerersWorkbench, HermesBoots);
            recipe.NewG((RecipeGroupID.IronBar, 3), (ItemID.Chain, 2), TinkerersWorkbench, ShoeSpikes);
            recipe.NewG((Flares, 10), Blowpipe, WorkBenches, FlareGun);
            recipe.New(Silk, Torch, WorkBenches, (Flare, 50));
            recipe.NewNg(ShinyRedBalloon, (GoldBars, 5), (Feather, 3), TinkerersWorkbench, LuckyHorseshoe);
        }

        public static void AddPyramidChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Pyramid Chest Loot Recipes");
            recipe.New(CloudinaBottle, (SandBlock, 25), TinkerersWorkbench, SandstorminaBottle);
            recipe.NewG((GoldBars, 5), Anvils, PharaohsMask);
            recipe.NewG((GoldBars, 5), Anvils, PharaohsRobe);
            recipe.New((Silk, 20), TileID.MythrilAnvil, FlyingCarpet);
        }

        public static void AddFrozenChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Frozen Chest Loot Recipes");
            recipe.New(MagicMirror, (ItemID.IceBlock, 25), TinkerersWorkbench, IceMirror);
        }

        public static void AddLihzahrdChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Lihzahrd Chest Loot Recipes");
            recipe.NewNng((ItemID.Glass, 10), (FallenStar, 25), (AdamantiteBars, 5), TileID.MythrilAnvil,
                LihzahrdPowerCell);
            recipe.New((ItemID.LihzahrdBrick, 10), WorkBenches, ItemID.LihzahrdFurnace);
        }

        public static void AddLivingWoodChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Living Wood Chest Loot Recipes");
            recipe.New((Wood, 15), TileID.Sawmill, ItemID.LivingLoom);
            recipe.New(LivingWoodWand, Bird, TileID.LivingLoom, BabyBirdStaff);
        }

        public static void AddMushroomChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Mushroom Chest Loot Recipes");
            recipe.New((ShroomiteBar, 4), TileID.Autohammer, MushroomHat);
            recipe.New((ShroomiteBar, 8), TileID.Autohammer, MushroomVest);
            recipe.New((ShroomiteBar, 6), TileID.Autohammer, MushroomPants);
        }

        public static void AddSanstoneChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Sanstone Chest Loot Recipes");
            recipe.New((StoneBlock, 999), WorkBenches, EncumberingStone);
            recipe.New((SunplateBlock, 10), WorkBenches, ItemID.SkyMill);
            recipe.New(SunplateBlock, (ItemID.Cobweb, 14), TileID.SkyMill, ItemID.Cloud);
        }

        public static void AddWebbedChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Webbed Chest Loot Recipes");
            recipe.New(GrapplingHook, (ItemID.Cobweb, 42), TileID.TinkerersWorkbench, WebSlinger);
        }

        public static void AddTrapsRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Traps Recipes");
            recipe.New((StoneBlock, 20), (WoodenArrow, 100), (Wire, 20), TileID.MythrilAnvil, DartTrap);
            recipe.New((StoneBlock, 20), (LavaBucket, 3), (Wire, 20), (PressurePlates, 2), TileID.MythrilAnvil,
                ItemID.GeyserTrap);
            recipe.New((DartTrap, 3), (ItemID.LihzahrdBrick, 5), (Wire, 20), EndlessQuiver, TileID.MythrilAnvil, SuperDartTrap);
            recipe.New(SuperDartTrap, (SpikyBall, 100), TileID.MythrilAnvil, SpikyBallTrap);
            recipe.New(SuperDartTrap, (Spear, 3), TileID.MythrilAnvil, SpearTrap);
            recipe.New(SuperDartTrap, ItemID.GeyserTrap, TileID.MythrilAnvil, FlameTrap);
            recipe.New((ItemID.Chain, 2), (RecipeGroupID.IronBar, 3), (WoodenArrow, 5), Anvils, (Spike, 10));
            recipe.New((Spike, 25), ItemID.LihzahrdBrick, TileID.MythrilAnvil, (WoodenSpike, 10));
            recipe.New(Fake_GoldChest, GoldChest, Anvils, DeadMansChest);
            recipe.New(DeadMansChest, TileID.Loom, DeadMansSweater);
        }

        public static void AddUntrapChestRecipes(RecipeCreator recipe)
        {
            recipe.StartNewRecipeSection("Untrap Chest Recipes");
            recipe.New(Fake_BambooChest, TileID.HeavyWorkBench, BambooChest);
            recipe.New(Fake_BlueDungeonChest, TileID.HeavyWorkBench, BlueDungeonChest);
            recipe.New(Fake_BoneChest, TileID.HeavyWorkBench, BoneChest);
            recipe.New(Fake_BorealWoodChest, TileID.HeavyWorkBench, BorealWoodChest);
            recipe.New(Fake_CactusChest, TileID.HeavyWorkBench, CactusChest);
            recipe.New(Fake_Chest, TileID.HeavyWorkBench, Chest);
            recipe.New(Fake_CorruptionChest, TileID.HeavyWorkBench, CorruptionChest);
            recipe.New(Fake_CrimsonChest, TileID.HeavyWorkBench, CrimsonChest);
            recipe.New(Fake_CrystalChest, TileID.HeavyWorkBench, CrystalChest);
            recipe.New(Fake_DesertChest, TileID.HeavyWorkBench, DesertChest);
            recipe.New(Fake_DynastyChest, TileID.HeavyWorkBench, DynastyChest);
            recipe.New(Fake_EbonwoodChest, TileID.HeavyWorkBench, EbonwoodChest);
            recipe.New(Fake_FleshChest, TileID.HeavyWorkBench, FleshChest);
            recipe.New(Fake_FrozenChest, TileID.HeavyWorkBench, FrozenChest);
            recipe.New(Fake_GlassChest, TileID.HeavyWorkBench, GlassChest);
            recipe.New(Fake_GoldChest, TileID.HeavyWorkBench, GoldChest);
            recipe.New(Fake_GoldenChest, TileID.HeavyWorkBench, GoldenChest);
            recipe.New(Fake_GolfChest, TileID.HeavyWorkBench, GolfChest);
            recipe.New(Fake_GraniteChest, TileID.HeavyWorkBench, GraniteChest);
            recipe.New(Fake_GreenDungeonChest, TileID.HeavyWorkBench, GreenDungeonChest);
            recipe.New(Fake_HallowedChest, TileID.HeavyWorkBench, HallowedChest);
            recipe.New(Fake_HoneyChest, TileID.HeavyWorkBench, HoneyChest);
            recipe.New(Fake_IceChest, TileID.HeavyWorkBench, IceChest);
            recipe.New(Fake_IvyChest, TileID.HeavyWorkBench, IvyChest);
            recipe.New(Fake_JungleChest, TileID.HeavyWorkBench, JungleChest);
            recipe.New(Fake_LesionChest, TileID.HeavyWorkBench, LesionChest);
            recipe.New(Fake_LihzahrdChest, TileID.HeavyWorkBench, LihzahrdChest);
            recipe.New(Fake_LivingWoodChest, TileID.HeavyWorkBench, LivingWoodChest);
            recipe.New(Fake_MarbleChest, TileID.HeavyWorkBench, MarbleChest);
            recipe.New(Fake_MartianChest, TileID.HeavyWorkBench, MartianChest);
            recipe.New(Fake_MeteoriteChest, TileID.HeavyWorkBench, MeteoriteChest);
            recipe.New(Fake_MushroomChest, TileID.HeavyWorkBench, MushroomChest);
            recipe.New(Fake_NebulaChest, TileID.HeavyWorkBench, NebulaChest);
            recipe.New(Fake_ObsidianChest, TileID.HeavyWorkBench, ObsidianChest);
            recipe.New(Fake_PalmWoodChest, TileID.HeavyWorkBench, PalmWoodChest);
            recipe.New(Fake_PearlwoodChest, TileID.HeavyWorkBench, PearlwoodChest);
            recipe.New(Fake_PinkDungeonChest, TileID.HeavyWorkBench, PinkDungeonChest);
            recipe.New(Fake_PumpkinChest, TileID.HeavyWorkBench, PumpkinChest);
            recipe.New(Fake_RichMahoganyChest, TileID.HeavyWorkBench, RichMahoganyChest);
            recipe.New(Fake_DesertChest, TileID.HeavyWorkBench, DesertChest);
            recipe.New(Fake_ShadewoodChest, TileID.HeavyWorkBench,ShadewoodChest);
            recipe.New(Fake_ShadowChest, TileID.HeavyWorkBench, ShadowChest);
            recipe.New(Fake_SkywareChest, TileID.HeavyWorkBench, SkywareChest);
            recipe.New(Fake_SlimeChest, TileID.HeavyWorkBench, SlimeChest);
            recipe.New(Fake_SolarChest, TileID.HeavyWorkBench, SolarChest);
            recipe.New(Fake_SpiderChest, TileID.HeavyWorkBench, SpiderChest);
            recipe.New(Fake_SpookyChest, TileID.HeavyWorkBench, SpookyChest);
            recipe.New(Fake_StardustChest, TileID.HeavyWorkBench, StardustChest);
            recipe.New(Fake_SteampunkChest, TileID.HeavyWorkBench, SteampunkChest);
            recipe.New(Fake_VortexChest, TileID.HeavyWorkBench, VortexChest);
            recipe.New(Fake_WaterChest, TileID.HeavyWorkBench, WaterChest);
            recipe.New(Fake_WebCoveredChest, TileID.HeavyWorkBench, WebCoveredChest);
        }
    }
}