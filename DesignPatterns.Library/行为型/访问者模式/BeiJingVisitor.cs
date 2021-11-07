using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 具体访问者 -- 北京
    /// </summary>
    public class BeiJingVisitor : IVisitor
    {
        /// <summary>
        /// 具体访问者对具体元素的操作逻辑
        /// </summary>
        /// <param name="element"></param>
        public void Visit(AlienElement element)
        {
            element.Operation();
            Console.WriteLine("这里是北京，我们在考虑怎么去接待它");
        }
    }
}
