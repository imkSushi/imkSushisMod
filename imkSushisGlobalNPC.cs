using imkSushisMod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace imkSushisMod;

public class imkSushisGlobalNPC:GlobalNPC
{
	public void TeleportNpcToPlayer(NPC npc, Player player)
	{
		npc.position = player.position;
	}

	private static void AddItemWithCustomPrice(NPCShop shop, int type, int price, params Condition[] conditions)
	{
		var entry = new NPCShop.Entry(type, conditions);
		entry.Item.shopCustomPrice = price;
		shop.Add(entry);
	}
	private static Condition DownedPumpkinMoonBossAny = new Condition("imkSushisMod.Conditions.DownedPumpkinMoonBossAny", () => NPC.downedHalloweenTree || NPC.downedHalloweenKing);
	private static Condition DownedFrostMoonBossAny = new Condition("imkSushisMod.Conditions.DownedFrostMoonBossAny", () => NPC.downedChristmasIceQueen || NPC.downedChristmasTree || NPC.downedChristmasSantank);

	public override void ModifyShop(NPCShop shop)
	{
		if(shop.NpcType == NPCID.Wizard)
		{
			shop.Add<LesserTimeSphere>(Condition.Hardmode);
			shop.Add<TimeSphere>(Condition.DownedMechBossAny);
			shop.Add<GreaterTimeSphere>(Condition.DownedPlantera);
			shop.Add<SuperTimeSphere>(Condition.DownedMoonLord);
		}

		//Boss Summons
		if(shop.NpcType == NPCID.Dryad)
		{
			AddItemWithCustomPrice(shop, ItemID.SuspiciousLookingEye, 60000, Condition.DownedEyeOfCthulhu);
			AddItemWithCustomPrice(shop, ItemID.WormFood, 30000, Condition.DownedEowOrBoc);
			AddItemWithCustomPrice(shop, ItemID.BloodySpine, 30000, Condition.DownedEowOrBoc);
			AddItemWithCustomPrice(shop, ItemID.SlimeCrown, 20000, Condition.DownedKingSlime);
			AddItemWithCustomPrice(shop, ItemID.Abeemination, 200000, Condition.DownedQueenBee);
		}
		if(shop.NpcType == NPCID.Steampunker)
		{
			AddItemWithCustomPrice(shop, ItemID.MechanicalWorm, 240000, Condition.DownedDestroyer);
			AddItemWithCustomPrice(shop, ItemID.MechanicalEye, 240000, Condition.DownedTwins);
			AddItemWithCustomPrice(shop, ItemID.MechanicalSkull, 240000, Condition.DownedSkeletronPrime);
		}
		if(shop.NpcType == NPCID.WitchDoctor)
		{
			AddItemWithCustomPrice(shop, ItemType<MysteriousSeed>(), 300000, Condition.DownedPlantera);
		}
		if(shop.NpcType == NPCID.Cyborg)
		{
			AddItemWithCustomPrice(shop, ItemID.LihzahrdPowerCell, 300000, Condition.DownedGolem);
		}
		if(shop.NpcType == NPCID.Wizard)
		{
			AddItemWithCustomPrice(shop, ItemID.TruffleWorm, 100000, Condition.DownedDukeFishron);
			AddItemWithCustomPrice(shop, ItemID.CelestialSigil, 200000, Condition.DownedMoonLord);
		}

		//Moons
		if(shop.NpcType == NPCID.Wizard)
		{
			//Pumpkin Moon
			AddItemWithCustomPrice(shop, ItemID.PumpkinMoonMedallion, 200000, DownedPumpkinMoonBossAny);
			AddItemWithCustomPrice(shop, ItemType<FieryStick>(), 20000, Condition.DownedMourningWood);
			AddItemWithCustomPrice(shop, ItemType<PumpkingsCrown>(), 100000, Condition.DownedPumpking);

			//Frost Moon
			AddItemWithCustomPrice(shop, ItemID.NaughtyPresent, 200000, DownedFrostMoonBossAny);
			AddItemWithCustomPrice(shop, ItemType<Snowflake>(), 20000, Condition.DownedIceQueen);
			AddItemWithCustomPrice(shop, ItemType<IcyBranch>(), 20000, Condition.DownedEverscream);
			AddItemWithCustomPrice(shop, ItemType<ToyTank>(), 20000, Condition.DownedSantaNK1);
		}

		//Invasions
		if(shop.NpcType == NPCID.GoblinTinkerer)
		{
			AddItemWithCustomPrice(shop, ItemID.GoblinBattleStandard, 100000, Condition.DownedGoblinArmy);
		}
		if(shop.NpcType == NPCID.PirateCaptain)
		{
			AddItemWithCustomPrice(shop, ItemID.PirateMap, 200000, Condition.DownedPirates);
		}
		if(shop.NpcType == NPCID.WitchDoctor)
		{
			AddItemWithCustomPrice(shop, ItemID.SolarTablet, 300000, Condition.DownedGolem);
		}
		if(shop.NpcType == NPCID.Cyborg)
		{
			AddItemWithCustomPrice(shop, ItemType<MartianRocket>(), 200000, Condition.DownedMartians);
		}
	}
}