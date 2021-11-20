using Otherlands.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class GrimScythe : ModItem 
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Grim Scythe");
			Tooltip.SetDefault("Sharpened by Reapers."); 
		}

		public override void SetDefaults() {
			item.damage = 60;
			item.melee = true; 
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.noMelee = false;//so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SparklingStar>();
			item.shootSpeed = 16f;
		}
	}
}