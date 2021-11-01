using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.策略模式
{
    /// <summary>
    /// 策略抽象
    /// 出行方式策略
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// 出发
        /// </summary>
        void StartOff();
    }
}
