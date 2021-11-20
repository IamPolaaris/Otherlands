using Otherlands.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class BoomCrystal : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("BoomCrystal");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.Boomstick);
			item.shootSpeed *= 0.75f;
			item.damage = (int)(item.damage * 5.5);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			type = ModContent.ProjectileType<ExampleCloneProjectile>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
} 