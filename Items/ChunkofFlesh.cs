using Otherlands.NPCs;
using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace Otherlands.Items
{
    public class ChunkofFlesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chunk of Flesh");
            Tooltip.SetDefault("Summons The ancient Worm.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 20;
            item.rare = 4;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.consumable = true;
        }
		
        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position);
            if(Main.netMode != 1)
            {
                NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<MoltenGodHead>());
            }
            return true;
			
		}					public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HellfireStone", 5); 
			recipe.AddIngredient(ItemID.HellstoneBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}