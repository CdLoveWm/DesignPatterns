using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.桥接模式
{
    /// <summary>
    /// 颜色抽象
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// 获取颜色
        /// </summary>
        string GetColor();
    }
}
