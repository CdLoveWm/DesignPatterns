using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.适配器模式
{
    /// <summary>
    /// 被适配对象
    /// </summary>
    public class Adaptee220V
    {
        public void Show()
        {
            Console.WriteLine("这是220V电压");
        }
    }
}
