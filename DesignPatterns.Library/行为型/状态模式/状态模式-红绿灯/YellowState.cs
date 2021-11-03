using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.状态模式
{
    /// <summary>
    /// 具体状态-黄灯
    /// </summary>
    public class YellowState : AbstractState
    {
        public YellowState(TrafficLightContext context) : base(context)
        {
        }

        public override void LightOnToAction()
        {
            Console.WriteLine("黄灯亮，车辆/行人谨慎通行或者停车等待");
            context.state = new RedState(context);
        }
    }
}
