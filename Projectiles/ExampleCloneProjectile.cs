
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Projectiles
{
	public class ExampleCloneProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("BoomCrystal");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Bullet);
			aiType = ProjectileID.Bullet;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Bullet;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, ProjectileID.Bullet, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = false;
			}
			return true;
		}
	}
}