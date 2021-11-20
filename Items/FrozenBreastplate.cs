using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class FrozenBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Frozen Breastplate");
			Tooltip.SetDefault("Hidden by the gods."
				+ "\n+14% increased melee damage and melee speed.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 19;
		}

		public override void UpdateEquip(Player player) {
			player.meleeDamage *= 1.14f; 
			player.meleeSpeed *= 1.14f;
			
		}

		public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1); 
			recipe.AddIngredient(mod, "MysteriousNote", 1); 
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}