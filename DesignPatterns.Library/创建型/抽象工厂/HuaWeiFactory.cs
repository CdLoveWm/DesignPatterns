using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 华为工厂
    /// </summary>
    public class HuaWeiFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new HuaWeiComputer();
        }

        public IPhone CreatePhone()
        {
            return new HuaWeiPhone();
        }
    }
}
