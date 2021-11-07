using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// 接收具体元素类调用，传入具体元素进行不同访问者的不同操作
        /// </summary>
        /// <param name="element"></param>
        void Visit(AlienElement element);
    }
}
