using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 具体访问者 -- 广东
    /// </summary>
    public class GuangDongVisitor : IVisitor
    {
        /// <summary>
        /// 具体访问者对具体元素的操作逻辑
        /// </summary>
        /// <param name="element"></param>
        public void Visit(AlienElement element)
        {
            element.Operation();
            Console.WriteLine("这里是广东，我们正在想这玩意怎么吃");
        }
    }
}
