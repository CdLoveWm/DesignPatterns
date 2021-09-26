using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.建造者模式
{
    /// <summary>
    /// 具体建造者：现代风格
    /// </summary>
    public class SmartnessStyleBuilder : AbstractBuilder
    {
        public override void InstallWardrobe()
        {
            house.Wardrobe = "实木衣柜";
        }
        public override void Paint()
        {
            house.Paint = "乳胶漆";
        }
        public override void Tiling()
        {
            house.Wardrobe = "广东转80*1600";
        }
    }
}
