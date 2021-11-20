using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class Grim_Bar : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Ghostly...");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}
	}
}