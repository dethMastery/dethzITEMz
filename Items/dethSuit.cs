using Terraria.ID;
using Terraria.ModLoader;

namespace dethzITEMz.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class dethSuit : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("deth's Costume");
            Tooltip.SetDefault("wow! my costume~ uwu~");
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
            recipe.AddIngredient(ItemID.DirtBlock, 1);
             recipe.AddTile(TileID.Anvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
