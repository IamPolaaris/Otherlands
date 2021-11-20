using Otherlands.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class BladeofJustice : ModItem 
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blade Of Justice");
			Tooltip.SetDefault("Huh..?"); 
		}

		public override void SetDefaults() {
			item.damage = 150;
			item.melee = true; 
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SparklingOrb>();
			item.shootSpeed = 16f;
		}
	}
}