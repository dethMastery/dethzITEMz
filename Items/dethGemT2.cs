using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items
{
	public class dethGemT2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("deth's Gem Tier 2");
			Tooltip.SetDefault("An upgraded material from tier 1. :D \nMystery Material");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = -12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "dethGemT1", 3);
			recipe.AddIngredient(ItemID.Gel, 3);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.anyIronBar = true;
			recipe.AddTile(mod, "dethBenchP");
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}
