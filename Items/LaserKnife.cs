using Terraria.ID;
using Terraria.ModLoader;
using Otherlands.Projectiles;

namespace Otherlands.Items
{
	public class LaserKnife : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Laser Knife");
			Tooltip.SetDefault("Martian Technology..");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.melee = true;
			item.shootSpeed = 14;
			item.width = 120;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<LaserProjectile>();
			item.autoReuse = true;
		}
	}
}