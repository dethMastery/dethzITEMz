using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class dethAssWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("deth's fucking wing");
			Tooltip.SetDefault("Im tired for running on street");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = -12;
			item.accessory = true;
			item.maxStack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 1200; //wings Height
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "dethGemT2", 5);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddTile(mod.TileType("dethBenchP"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}