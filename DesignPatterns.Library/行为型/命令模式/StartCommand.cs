using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.命令模式
{
    /// <summary>
    /// 具体命令-电视开机命令
    /// </summary>
    public class StartCommand : ICommand
    {
        private readonly Television _tv;
        public StartCommand(Television tv)
        {
            this._tv = tv;
        }
        /// <summary>
        /// 开机
        /// </summary>
        public void Excute()
        {
            _tv.Start();
        }
    }
}
