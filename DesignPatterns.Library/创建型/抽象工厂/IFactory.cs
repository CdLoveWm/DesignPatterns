using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型.抽象工厂
{
    /// <summary>
    /// 工厂接口
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// 电脑
        /// </summary>
        /// <returns></returns>
        IComputer CreateComputer();
        /// <summary>
        /// 手机
        /// </summary>
        /// <returns></returns>
        IPhone CreatePhone();
    }
}
