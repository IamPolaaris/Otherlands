using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
  public class FleshHandgun : ModItem
  {
  public override void SetStaticDefaults()
  {
  DisplayName.SetDefault("Flesh Handgun");
  Tooltip.SetDefault("Made from Worm Flesh"); 
  }

  public override void SetDefaults()
  {
  item.damage = 12;
  item.ranged = true;
  item.width = 12;
  item.height = 38;
  item.maxStack = 1;
  item.useTime = 10;
  item.useAnimation = 10;
  item.useStyle = 5;
  item.knockBack = 1;
  item.value = 12000;
  item.rare = 2;
  item.UseSound = SoundID.Item11;
  item.noMelee = true;
  item.shoot = 1;
  item.useAmmo = AmmoID.Bullet;
  item.shootSpeed = 10f;
  item.autoReuse = true;
  }
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshBar", 8); 
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		    }
	  
   }
}