using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace dethzITEMz.Tiles
{
	public class dethBench : ModTile
	{
		//public override void SetStaticDefaults()
		//{
		//	DisplayName.SetDefault("deth's Working bench");
		//	Tooltip.SetDefault("Just my starter workbench");
		//}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.useTime = 3;
			item.rare = -12;
			item.useAnimation = 17;

			item.createTile = mod.TileType("dethBench");
			item.consumable = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.addTile(Type);

			DisplayName.SetDefault("deth's Working bench");
			Tooltip.SetDefault("Just my starter workbench");
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(9, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
