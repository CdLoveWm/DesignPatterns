using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 具体元素类 -- 外星人
    /// </summary>
    public class AlienElement : IElement
    {
        /// <summary>
        /// 接受具体访问者
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// 这里可以添加该具体元素自己的方法
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("外星人掉落了...");
        }
    }
}
