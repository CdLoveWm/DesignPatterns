using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.建造者模式
{
    /// <summary>
    /// 指挥者
    /// </summary>
    public class Director
    {
        private AbstractBuilder builder;
        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }
        /// <summary>
        /// 控制装修顺序，得到装修好的房子
        /// </summary>
        /// <returns></returns>
        public House GetHouse()
        {
            builder.Tiling();
            builder.InstallWardrobe();
            builder.Paint();
            return builder.GetHouse();
        }
    }
}
