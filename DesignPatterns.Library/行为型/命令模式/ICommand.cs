using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.命令模式
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 命令执行
        /// </summary>
        public void Excute();
    }
}
