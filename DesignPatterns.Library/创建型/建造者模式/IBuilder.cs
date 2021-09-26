using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.建造者模式
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class IBuilder
    {
        /// <summary>
        /// 将具体产品（房子）聚合进来
        /// </summary>
        protected House house = new House();
        /// <summary>
        /// 贴砖
        /// </summary>
        public abstract void Tiling();
        /// <summary>
        /// 安装衣柜
        /// </summary>
        public abstract void InstallWardrobe();
        /// <summary>
        /// 刷漆
        /// </summary>
        public abstract void Paint();
        /// <summary>
        /// 得到装修好的房子
        /// </summary>
        /// <returns></returns>
        public virtual House GetHouse()
        {
            return house;
        }
    }
}
