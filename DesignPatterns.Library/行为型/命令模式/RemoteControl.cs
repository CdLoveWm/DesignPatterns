using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.命令模式
{
    /// <summary>
    /// 命令发送者--电视遥控器
    /// </summary>
    public class RemoteControl
    {
        private readonly ICommand _command;
        public RemoteControl(ICommand command)
        {
            this._command = command;
        }
        /// <summary>
        /// 发送命令
        /// </summary>
        public void Action()
        {
            _command.Excute();
        }
    }
}
