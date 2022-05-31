using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items
{
	public class dethGemT1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("deth's Gem Tier 1");
			Tooltip.SetDefault("Just a fucking gem that making by some of fucking dirt, wood & stone. \nMystery Material");
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
			recipe.AddIngredient(ItemID.DirtBlock, 3);
			recipe.AddIngredient(ItemID.StoneBlock, 3);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.anyWood = true;
			recipe.AddTile(mod, "dethBenchP");
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}
