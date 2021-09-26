using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 小米电话
    /// </summary>
    public class XiaoMiPhone : IPhone
    {
        public void Show()
        {
            Console.WriteLine("小米电话");
        }
    }
}
