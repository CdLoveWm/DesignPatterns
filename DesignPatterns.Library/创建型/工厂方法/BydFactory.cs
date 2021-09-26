using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂方法
{
    /// <summary>
    /// 比亚迪汽车工厂
    /// </summary>
    public class BydFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new BydCar();
        }
    }
}
