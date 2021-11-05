using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.观察者模式
{
    /// <summary>
    /// 具体观察者角色 -- 小偷
    /// </summary>
    public class ThiefObserver : IObserver
    {
        public void Response()
        {
            Console.WriteLine("小偷吓了一跳...");
        }
    }
}
