using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class FleshScimitar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Flesh Scimitar");
			Tooltip.SetDefault("Stonewashed Steel Blade, must be worth a fortune...");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 120;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshBar", 10); 
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}