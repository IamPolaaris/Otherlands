using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
  public class Bow_of_Trees : ModItem
  {
  public override void SetStaticDefaults()
  {
  DisplayName.SetDefault("Bow of Mecha");
  Tooltip.SetDefault("Hand-crafted from Glowing Mecha-Plates."); 
  }

  public override void SetDefaults()
  {
  item.damage = 120;
  item.ranged = true;
  item.width = 12;
  item.height = 38;
  item.maxStack = 1;
  item.useTime = 15;
  item.useAnimation = 15;
  item.useStyle = 5;
  item.knockBack = 2;
  item.value = 12000;
  item.rare = 2;
  item.UseSound = SoundID.Item5;
  item.noMelee = true;
  item.shoot = 1;
  item.useAmmo = AmmoID.Arrow;
  item.shootSpeed = 10f;
  item.autoReuse = true;
  }
  }
}