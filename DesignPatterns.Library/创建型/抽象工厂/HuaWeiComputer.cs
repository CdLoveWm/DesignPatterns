using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 华为电脑
    /// </summary>
    public class HuaWeiComputer : IComputer
    {
        public void Show()
        {
            Console.WriteLine("华为电脑");
        }
    }
}
