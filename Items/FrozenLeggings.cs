using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class FrozenLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Boosts power from the Frost Gods."
				+ "\n5% increased movement speed,9% Increased melee Damage, 7% melee Speed."); 
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 16; 
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
			player.meleeDamage *= 1.09f; 
			player.meleeSpeed *= 1.07f;
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