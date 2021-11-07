using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 抽象元素类
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// 接受具体的访问者
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IVisitor visitor);
    }
}
