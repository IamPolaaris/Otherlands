
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Projectiles
{
	public class LaserProjectile : ModProjectile
	{
		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.VampireKnife);
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 600;
            projectile.aiStyle = 304;
		}

		
		
	}
}