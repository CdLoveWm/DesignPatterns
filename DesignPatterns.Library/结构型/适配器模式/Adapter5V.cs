using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.适配器模式
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class Adapter5V : ITarget5V
    {
        /// <summary>
        /// 这里也可以通过构造函数传入
        /// </summary>
        private Adaptee220V adaptee220V = new Adaptee220V();
        public void Adapt5V()
        {
            adaptee220V.Show();
            Console.WriteLine("正在使用阻容降压电脑进行转换");
            Console.WriteLine("得到5V电压");
        }
    }
}
