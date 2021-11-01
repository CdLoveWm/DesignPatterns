using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.组合模式
{
    /// <summary>
    /// 抽象节点(IComponent)
    /// </summary>
    public interface IDirectory
    {
        /// <summary>
        /// 显示
        /// </summary>
        void Show();
    }
}
