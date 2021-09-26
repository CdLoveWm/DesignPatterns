using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 小米工厂
    /// </summary>
    public class XiaoMiFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new XiaoMiComputer();
        }

        public IPhone CreatePhone()
        {
            return new XiaoMiPhone();
        }
    }
}
