using imkSushisMod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace imkSushisMod;

public class imkSushisGlobalNPC : GlobalNPC
{
    public void TeleportNpcToPlayer(NPC npc, Player player)
    {
        npc.position = player.position;
    }

	public override void SetupShop(int type, Chest shop, ref int nextSlot)
	{
		if (type == NPCID.Wizard)
		{
			shop.item[nextSlot].SetDefaults(ItemType<LesserTimeSphere>());
			nextSlot++;
			if (NPC.downedMechBossAny)
			{
				shop.item[nextSlot].SetDefaults(ItemType<TimeSphere>());
				nextSlot++;
			}
			if (NPC.downedPlantBoss)
			{
				shop.item[nextSlot].SetDefaults(ItemType<GreaterTimeSphere>());
				nextSlot++;
			}
			if (NPC.downedMoonlord)
			{
				shop.item[nextSlot].SetDefaults(ItemType<SuperTimeSphere>());
				nextSlot++;
			}
		}
		if (type == NPCID.Mechanic)
		{
			shop.item[nextSlot].SetDefaults(ItemID.Teleporter);
				shop.item[nextSlot].shopCustomPrice = 50000;
			nextSlot++;
		}
		if (type == NPCID.Dryad && NPC.downedBoss1)
		{
			shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
			shop.item[nextSlot].shopCustomPrice = 60000;
			nextSlot++;
		}

		if (type == NPCID.Dryad && NPC.downedBoss2)
		{
			shop.item[nextSlot].SetDefaults(ItemID.WormFood);
			shop.item[nextSlot].shopCustomPrice = 30000;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
			shop.item[nextSlot].shopCustomPrice = 30000;
			nextSlot++;
		}

		if (type == NPCID.Dryad && NPC.downedSlimeKing)
		{
			shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
			shop.item[nextSlot].shopCustomPrice = 20000;
			nextSlot++;
		}

		if (type == NPCID.Dryad && NPC.downedQueenBee)
		{
			shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;
		}

		if (type == NPCID.Steampunker && NPC.downedMechBoss1)
		{
			shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
			shop.item[nextSlot].shopCustomPrice = 240000;
			nextSlot++;
		}

		if (type == NPCID.Steampunker && NPC.downedMechBoss2)
		{
			shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
			shop.item[nextSlot].shopCustomPrice = 240000;
			nextSlot++;
		}

		if (type == NPCID.Steampunker && NPC.downedMechBoss3)
		{
			shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
			shop.item[nextSlot].shopCustomPrice = 240000;
			nextSlot++;
		}

		if (type == NPCID.Cyborg && NPC.downedGolemBoss)
		{
			shop.item[nextSlot].SetDefaults(ItemID.LihzahrdPowerCell);
			shop.item[nextSlot].shopCustomPrice = 300000;
			nextSlot++;
		}

		if (type == NPCID.Wizard && NPC.downedMoonlord)
		{
			shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;
		}
		if (type == NPCID.Wizard && (NPC.downedHalloweenTree || NPC.downedHalloweenKing))
		{
			shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;
				
			if (NPC.downedHalloweenTree)
			{
				shop.item[nextSlot].SetDefaults(ItemType<FieryStick>());
				shop.item[nextSlot].shopCustomPrice = 20000;
				nextSlot++;
			}
				
			if (NPC.downedHalloweenKing)
			{
				shop.item[nextSlot].SetDefaults(ItemType<PumpkingsCrown>());
				shop.item[nextSlot].shopCustomPrice = 100000;
				nextSlot++;
			}
		}

		if (type == NPCID.Wizard && (NPC.downedChristmasIceQueen || NPC.downedChristmasTree || NPC.downedChristmasSantank))
		{
			shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;

			if (NPC.downedChristmasIceQueen)
			{
				shop.item[nextSlot].SetDefaults(ItemType<Snowflake>());
				shop.item[nextSlot].shopCustomPrice = 20000;
				nextSlot++;
			}
				
			if (NPC.downedChristmasTree)
			{
				shop.item[nextSlot].SetDefaults(ItemType<IcyBranch>());
				shop.item[nextSlot].shopCustomPrice = 20000;
				nextSlot++;
			}
				
			if (NPC.downedChristmasSantank)
			{
				shop.item[nextSlot].SetDefaults(ItemType<ToyTank>());
				shop.item[nextSlot].shopCustomPrice = 20000;
				nextSlot++;
			}
		}

		if (type == NPCID.Wizard && NPC.downedFishron)
		{
			shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
			shop.item[nextSlot].shopCustomPrice = 100000;
			nextSlot++;
		}

		if (type == NPCID.GoblinTinkerer)
		{
			shop.item[nextSlot].SetDefaults(ItemID.GoblinBattleStandard);
			shop.item[nextSlot].shopCustomPrice = 100000;
			nextSlot++;
		}

		if (type == NPCID.PirateCaptain)
		{
			shop.item[nextSlot].SetDefaults(ItemID.PirateMap);
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;
		}

		if (type == NPCID.Wizard)
		{
			shop.item[nextSlot].SetDefaults(ItemType<BloodOrb>());
			shop.item[nextSlot].shopCustomPrice = 50000;
			nextSlot++;
		}

		if (type == NPCID.Cyborg && NPC.downedMartians)
		{
			shop.item[nextSlot].SetDefaults(ItemType<MartianRocket>());
			shop.item[nextSlot].shopCustomPrice = 200000;
			nextSlot++;
		}

		if (type == NPCID.WitchDoctor && NPC.downedPlantBoss)
		{
			shop.item[nextSlot].SetDefaults(ItemType<MysteriousSeed>());
			shop.item[nextSlot].shopCustomPrice = 300000;
			nextSlot++;
		}
	}
}