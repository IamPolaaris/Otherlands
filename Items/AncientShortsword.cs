using Terraria.ID;
using Terraria.ModLoader;
using Otherlands.Projectiles;

namespace Otherlands.Items
{
	public class AncientShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ancient Shortsword");
			Tooltip.SetDefault("Cool, you found it!");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.melee = true;
			item.shootSpeed = 10;
			item.width = 120;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<DesertBeam>();
			item.autoReuse = true;
		}
			
			   public override void AddRecipes() {
			   ModRecipe recipe = new ModRecipe(mod);
			   recipe.AddIngredient(ItemID.Bone, 50); 
			   recipe.AddIngredient(ItemID.Muramasa, 1);
			   recipe.AddIngredient(ItemID.BlueMoon, 1); 
			   recipe.AddTile(TileID.Anvils);
			   recipe.SetResult(this);
			   recipe.AddRecipe();
	    }
	}
}