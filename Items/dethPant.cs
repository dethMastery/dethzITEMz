using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class dethPant : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("blank Costume");
            Tooltip.SetDefault("Why its so cold");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10;
            item.rare = -12;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "dethGemT1", 1);
            recipe.AddTile(mod.TileType("dethBenchP"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
