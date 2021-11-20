using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
  public class ForbiddenRifle : ModItem
  {
  public override void SetStaticDefaults()
  {
  DisplayName.SetDefault("Forbidden Rifle");
  Tooltip.SetDefault("Forbidden Weapon, Hidden by Mecha 10000 years Ago for no-one to find."); 
  }

  public override void SetDefaults()
  {
  item.damage = 180;
  item.ranged = true;
  item.width = 12;
  item.height = 38;
  item.maxStack = 1;
  item.useTime = 19;
  item.useAnimation = 19;
  item.useStyle = 5;
  item.knockBack = 2;
  item.value = 12000;
  item.rare = 2;
  item.UseSound = SoundID.Item11;
  item.noMelee = true;
  item.shoot = 1;
  item.useAmmo = AmmoID.Bullet;
  item.shootSpeed = 10f;
  item.autoReuse = true;
  }
  }
}