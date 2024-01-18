using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Models
{
    public class EntityLook
    {
        public uint Bones { get; set; }
        public List<uint> Skins { get; set; } = new();
        public List<int> Colors { get; set; } = new();
        public List<int> Scales { get; set; } = new();

        public EntityLook(string datas, bool isPnj = false)
        {
            if (string.IsNullOrEmpty(datas))
                return;
            var dts = datas.Substring(1).Substring(0, datas.Length - 2).Split('|');
            try
            {
                Bones = uint.Parse(dts[0]);
                if (dts.Length <= 1)
                    return;
                if (dts.Length >= 2 && !string.IsNullOrEmpty(dts[1]))
                    Skins = dts[1].Split(',').Select(x => uint.Parse(x)).ToList();
                if (dts.Length >= 3 && !string.IsNullOrEmpty(dts[2]) && (isPnj || dts[2].Contains('=')))
                {
                    var baseColors = new int[5];
                    var colors = dts[2].Split(',');
                    for (int i = 0; i < colors.Length; i++)
                    {
                        var index = colors[i].Split('=')[0];
                        var color = Convert.ToInt32(colors[i].Split('=')[1].Substring(1), 16);
                        baseColors[int.Parse(index) - 1] = (((int.Parse(index)) & 255) << 24 | color & 16777215);
                    }
                    Colors = baseColors.ToList();
                }
                else if (dts.Length >= 3 && !string.IsNullOrEmpty(dts[2]))
                    Colors = dts[2].Split(',').Select((x, i) => ((i + 1) & 255) << 24 | int.Parse(x) & 16777215).ToList();
                if (dts.Length >= 4 && !string.IsNullOrEmpty(dts[3]))
                    Scales = dts[3].Split(',').Select(x => int.Parse(x)).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine(dts);
                throw;
            }

        }
        public void Load(string datas)
        {
            var dts = datas.Substring(1).Substring(0, datas.Length - 1).Split('|');
            Bones = uint.Parse(dts[0]);
            Skins = dts[1].Split(',').Select(x => uint.Parse(x)).ToList();
            Colors = dts[2].Split(',').Select((x, i) => ((i + 1) & 255) << 24 | int.Parse(x) & 16777215).ToList();
            Scales = dts[3].Split(',').Select(x => int.Parse(x)).ToList();
        }

        public Common.Protocol.Types.EntityLook GetEntityLook()
        {
            return new Common.Protocol.Types.EntityLook()
            {
                bonesId = Bones,
                indexedColors = Colors.ToArray(),
                scales = Scales.ToArray(),
                skins = Skins.ToArray(),
                subentities = new Common.Protocol.Types.SubEntity[0] 
            };
        }
    }
}
