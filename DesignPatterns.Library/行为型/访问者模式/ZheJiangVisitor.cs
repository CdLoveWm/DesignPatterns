using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 具体访问者--浙江
    /// </summary>
    public class ZheJiangVisitor : IVisitor
    {
        /// <summary>
        /// 具体访问者对具体元素的操作逻辑
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Visit(AlienElement element)
        {
            element.Operation();
            Console.WriteLine("这里是浙江义乌，我们正在考虑如何做一个相同的模型");
        }
    }
}
