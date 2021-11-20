using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class FleshBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Flesh Breastplate");
			Tooltip.SetDefault("Made from rotten Flesh"
				+ "\n4% Increased Damage, 5% increased Movement Speed.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player) {
			player.allDamage += 0.4f; 
			player.moveSpeed += 0.5f;
			
		}

		public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshBar", 15); 
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}