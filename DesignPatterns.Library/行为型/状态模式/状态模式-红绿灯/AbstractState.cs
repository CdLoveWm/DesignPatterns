using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.状态模式
{
    /// <summary>
    /// 抽象状态
    /// </summary>
    public abstract class AbstractState
    {
        public TrafficLightContext context;
        public AbstractState(TrafficLightContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// 灯亮后做的事情
        /// </summary>
        public abstract void LightOnToAction();
    }
}
