using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.状态模式
{
    /// <summary>
    /// 环境类--红绿灯
    /// </summary>
    public class TrafficLightContext
    {
        public AbstractState state { get; set; }
        public TrafficLightContext()
        {
            this.state = new GreenState(this);
        }
        /// <summary>
        /// 运行
        /// </summary>
        public void Run()
        {
            state.LightOnToAction();
        }
    }
}
