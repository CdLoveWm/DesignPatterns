using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.桥接模式
{
    /// <summary>
    /// 抽象-形状
    /// </summary>
    public abstract class AbstractShape
    {
        protected readonly IColor color;
        public AbstractShape(IColor color)
        {
            this.color = color;
        }
        /// <summary>
        /// 显示具体形状
        /// </summary>
        public abstract void ShowSpecificShape();
    }
}
