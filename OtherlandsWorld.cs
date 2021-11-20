using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.Localization;
using System.Threading;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using System.IO;

namespace Otherlands
{
    public class OtherlandsWorld : ModWorld
    {
        public static bool DownedMoltenGod = false;

        public override void Initialize()
        {
            DownedMoltenGod = false;
        }

        public override TagCompound Save()
        {
            var Downed = new List<string>();
            if (DownedMoltenGod) Downed.Add("MoltenGod");

            return new TagCompound
            {
                {
                    "Version", 0
                },
                {
                    "Downed", Downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var Downed = tag.GetList<string>("Downed");
            DownedMoltenGod = Downed.Contains("MoltenGod");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                DownedMoltenGod = flags[0];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = DownedMoltenGod;

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            DownedMoltenGod = flags[0];
        }
    }
}