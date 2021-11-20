
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	[AutoloadEquip(EquipType.Shoes)]
	public class FleshWaders : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flesh Waders");
			Tooltip.SetDefault("They feel... Squishy.");
		}

		public override void SetDefaults() {
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue; 
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.accRunSpeed = 9f; // The player's maximum run speed with accessories
			player.moveSpeed += 3.10f; // The acceleration multiplier of the player's movement speed
		}
	}
}