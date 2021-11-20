using Terraria.ID;
using Terraria.ModLoader;

namespace Otherlands.Items
{
	public class FrozenNote : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Submerged in Some icy Liquid");
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