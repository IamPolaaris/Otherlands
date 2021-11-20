using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Otherlands.Items;

namespace Otherlands.NPCs
{
	// This ModNPC serves as an example of a complete AI example.
	public class FlyingSlime : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Winged Slime"); // Automatic from .lang files
			Main.npcFrameCount[npc.type] = 5; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 14; // This npc has a completely unique AI, so we set this to -1. The default aiStyle 0 will face the player, which might conflict with custom AI code.
			npc.damage = 24;
			npc.defense = 5;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldDaySlime.Chance * 0.3f;
		}
		
								 public override void NPCLoot()
						 {
						     if (Main.rand.Next(4) == 1) 
							 Item.NewItem(npc.getRect(), ModContent.ItemType<HellfireStone>(), 1);
						 }

		// Our texture is 32x32 with 2 pixels of padding vertically, so 34 is the vertical spacing.  These are for my benefit and the numbers could easily be used directly in the code below, but this is how I keep code organized.
		private const int Frame_Flutter_1 = -1;
		private const int Frame_Flutter_2 = 0;
		private const int Frame_Flutter_3 = 1;
		private const int Frame_Flutter_4 = 2;
		private const int Frame_Flutter_5 = 3;

		// Here in FindFrame, we want to set the animation frame our npc will use depending on what it is doing.
		// We set npc.frame.Y to x * frameHeight where x is the xth frame in our spritesheet, counting from 0. For convenience, I have defined some consts above.
		public override void FindFrame(int frameHeight) {
			// This makes the sprite flip horizontally in conjunction with the npc.direction.


				npc.frameCounter++;
				if (npc.frameCounter < 5) {
					npc.frame.Y = Frame_Flutter_1 * frameHeight;
				}
				else if (npc.frameCounter < 10) {
					npc.frame.Y = Frame_Flutter_2 * frameHeight;
				}
				else if (npc.frameCounter < 15) {
					npc.frame.Y = Frame_Flutter_3 * frameHeight;
				}
				else if (npc.frameCounter < 20) {
					npc.frame.Y = Frame_Flutter_4 * frameHeight;
				}
				else if (npc.frameCounter < 25) {
					npc.frame.Y = Frame_Flutter_5 * frameHeight;
				}
				
				else {
					npc.frameCounter = 5;
			}
		}	
	}
}