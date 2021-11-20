using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class FleshHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Fleshy.." 
			+ "\n4% Increased damage."); 
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player) {
			player.allDamage += 0.04f; 
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