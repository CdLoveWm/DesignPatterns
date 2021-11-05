using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.观察者模式
{
    /// <summary>
    /// 具体观察者角色 -- 老鼠
    /// </summary>
    public class MouseObserver : IObserver
    {
        public void Response()
        {
            Console.WriteLine("老鼠开始跑...");
        }
    }
}
