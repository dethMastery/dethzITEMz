using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace dethzITEMz.Tiles
{
	public class dethBenchP : ModTile
	{
		public override void SetDefaults()
		{
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.CoordinateHeights = new int[] {9, 9, 9};
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Width = 2;

            TileObjectData.newTile.Origin = new Point16(0, 0);

            TileObjectData.addTile(Type);

            //AddMapEntry(new Color(0, 0, 0), "dethBench");
            adjTiles = new int[] { 16 };
            //drop = mod.ItemType("dethBench");
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 9, j * 19, 27, 38, mod.TileType("dethBench"));
        }
    }
}
