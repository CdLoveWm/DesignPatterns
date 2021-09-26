using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂方法
{
    /// <summary>
    /// 哈佛汽车
    /// </summary>
    public class HavalCar : ICar
    {
        public void ShowCar()
        {
            Console.WriteLine("哈佛汽车");
        }
    }
}
