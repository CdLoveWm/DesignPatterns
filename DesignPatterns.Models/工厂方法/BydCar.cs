using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.工厂方法
{
    /// <summary>
    /// 比亚迪汽车
    /// </summary>
    public class BydCar : ICar
    {
        public void ShowCar()
        {
            Console.WriteLine("比亚迪汽车");
        }
    }
}
