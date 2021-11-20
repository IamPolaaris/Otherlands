using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class FleshLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Fleshy..."
				+ "\n5% increased movement speed, 3% Increased Damage."); 
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 6; 
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
			player.allDamage += 0.03f; 
		}
		public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshBar", 10); 
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}