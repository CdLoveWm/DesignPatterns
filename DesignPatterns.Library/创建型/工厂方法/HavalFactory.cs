using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂方法
{
    /// <summary>
    /// 哈弗汽车工厂
    /// </summary>
    public class HavalFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new HavalCar();
        }
    }
}
