using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items
{
	public class dethSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("dethSword");
			Tooltip.SetDefault("Just my starter sword~ uwu~");
		}
		public override void SetDefaults()
		{
			item.damage = 9000;
			item.melee = true;
			item.width = 40;
			item.height = 900;
			item.useTime = 3;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 60;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			// recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
