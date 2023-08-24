using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace imkSushisMod.Items;

public abstract class NPCSummoningPotion : ModItem
{
    public override void SetDefaults()
    {
        Item.useStyle = ItemUseStyleID.DrinkLiquid;
        Item.width = 18;
        Item.height = 30;
        Item.consumable = true;
        Item.useAnimation = 17;
        Item.useTime = 17;
        Item.useTurn = true;
        Item.rare = ItemRarityID.Blue;
        Item.maxStack = 30;
        Item.UseSound = SoundID.Item3;
    }
    
    public override LocalizedText DisplayName => Language.GetText(Mod.GetLocalizationKey("Common.NPCSummoningPotion.DisplayName")).WithFormatArgs(Lang.GetNPCName(NpcId));
    public override LocalizedText Tooltip => Language.GetText(Mod.GetLocalizationKey("Common.NPCSummoningPotion.Tooltip")).WithFormatArgs(Lang.GetNPCName(NpcId));

    public override bool CanUseItem(Player player)
    {
        return NPC.AnyNPCs(NpcId) || CanSpawn(player);
    }
    
    public abstract int NpcId { get; }

    public override bool? UseItem(Player player)
    {
        var id = NPC.FindFirstNPC(NpcId);
        if (id <= -1)
        {
            id = NPC.NewNPC(Terraria.Entity.GetSource_TownSpawn(), (int) player.position.X, (int) player.position.Y, NpcId, 1);
            Main.townNPCCanSpawn[NpcId] = false;
            OnSummoning();
            switch (Main.netMode)
            {
                case 0:
                    Main.NewText(Language.GetTextValue("Announcement.HasArrived", (object) Main.npc[id].FullName), (byte) 50, (byte) 125);
                    break;
                case 2:
                    ChatHelper.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasArrived", Main.npc[id].GetFullNetName()), new Color(50, 125, 255));
                    break;
            }
        }
        else
        {
            ModContent.GetInstance<imkSushisGlobalNPC>().TeleportNpcToPlayer(Main.npc[id], player);
        }
        return true;
    }

    public virtual void OnSummoning()
    {
        
    }

    public abstract bool CanSpawn(Player player);
}