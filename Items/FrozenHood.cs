using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class FrozenHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Frozen Hood, Forged by the warriors of the Frost realm." 
			+ "\n9% Increased melee Damage, 3% melee Speed."); 
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 19;
		}

		public override void UpdateEquip(Player player) {
			player.meleeDamage *= 1.09f; 
			player.meleeSpeed *= 1.03f;
		}

		public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FrozenNote", 1); 
			recipe.AddIngredient(mod, "MysteriousNote", 1); 
            recipe.AddIngredient(ItemID.MythrilBar, 13); 
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}