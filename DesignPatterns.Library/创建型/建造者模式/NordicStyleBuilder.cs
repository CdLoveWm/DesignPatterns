using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.建造者模式
{
    /// <summary>
    /// 具体建造者：北欧风格
    /// </summary>
    public class NordicStyleBuilder : IBuilder
    {
        public override void InstallWardrobe()
        {
            house.Wardrobe = "颗粒板衣柜";
        }
        public override void Paint()
        {
            house.Paint = "艺术漆";
        }
        public override void Tiling()
        {
            house.Wardrobe = "佛山转70*140";
        }
    }
}
