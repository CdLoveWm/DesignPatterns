using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.策略模式
{
    /// <summary>
    /// 旅游
    /// </summary>
    public class Travel
    {
        private IStrategy _strategy;
        public Travel(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        /// <summary>
        /// 出发
        /// </summary>
        public void Depart()
        {
            Console.WriteLine("准备出发旅行");
            if (_strategy != null)
                _strategy.StartOff();
        }
    }
}
