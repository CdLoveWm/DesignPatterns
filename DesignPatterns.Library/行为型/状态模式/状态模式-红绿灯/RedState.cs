using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.状态模式
{
    /// <summary>
    /// 具体状态-红灯
    /// </summary>
    public class RedState : AbstractState
    {
        public RedState(TrafficLightContext context) : base(context)
        {
        }

        public override void LightOnToAction()
        {
            Console.WriteLine("红灯亮，车辆/行人停车等待");
            context.state = new GreenState(context);
        }
    }
}
