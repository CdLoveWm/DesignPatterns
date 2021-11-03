using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.状态模式
{
    /// <summary>
    /// 具体状态-绿灯
    /// </summary>
    public class GreenState : AbstractState
    {
        public GreenState(TrafficLightContext context) : base(context)
        {
        }

        public override void LightOnToAction()
        {
            Console.WriteLine("绿灯亮，车辆/行人可以通行");
            context.state = new YellowState(context);
        }
    }
}
