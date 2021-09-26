using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 华为手机
    /// </summary>
    public class HuaWeiPhone : IPhone
    {
        public void Show()
        {
            Console.WriteLine("华为手机");
        }
    }
}
