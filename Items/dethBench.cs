using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items
{
	public class dethBench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("deth's Working bench");
			Tooltip.SetDefault("Just my starter workbench");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.useTime = 14;
			item.rare = -12;
			item.useAnimation = 17;
			item.useTurn = true;
			item.autoReuse = true;
			item.useStyle = 1;

			item.createTile = mod.TileType("dethBenchP");
			item.consumable = true;
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
