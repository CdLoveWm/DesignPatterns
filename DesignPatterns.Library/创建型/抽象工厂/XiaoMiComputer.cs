using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 小米电脑
    /// </summary>
    public class XiaoMiComputer : IComputer
    {
        public void Show()
        {
            Console.WriteLine("小米电脑");
        }
    }
}
