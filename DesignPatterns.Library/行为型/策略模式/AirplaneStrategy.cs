using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.策略模式
{
    /// <summary>
    /// 策略--飞机旅行
    /// </summary>
    public class AirplaneStrategy : IStrategy
    {
        public void StartOff()
        {
            Console.WriteLine("乘坐飞机旅行...");
        }
    }
}
