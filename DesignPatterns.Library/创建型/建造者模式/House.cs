using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.建造者模式
{
    /// <summary>
    /// 具体产品：装修好的房子
    /// </summary>
    public class House
    {
        /// <summary>
        /// 砖
        /// </summary>
        public string Brick { get; set; }
        /// <summary>
        /// 衣柜
        /// </summary>
        public string Wardrobe { get; set; }
        /// <summary>
        /// 漆
        /// </summary>
        public string Paint { get; set; }
    }
}
