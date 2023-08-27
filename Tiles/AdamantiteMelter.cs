using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace imkSushisMod.Tiles;

public class AdamantiteMelter : ModTile
{
    public override void SetStaticDefaults() {
        // Properties
        Main.tileLighted[Type] = true;
        Main.tileFrameImportant[Type] = true;
        Main.tileObsidianKill[Type] = true;
        Main.tileNoAttach[Type] = true;
        
        AdjTiles = new[] {ModContent.TileType<Melter>(), ModContent.TileType<Hellmelter>(), ModContent.TileType<TitaniumMelter>()};
        
        TileID.Sets.InteractibleByNPCs[Type] = true;

        // Placement
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
        TileObjectData.addTile(Type);

        // Etc
        AddMapEntry(new Color(231, 53, 56), CreateMapEntryName());
    }

    public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.83f;
        g = 0.6f;
        b = 0.5f;
    }
}