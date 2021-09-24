using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.工厂方法
{
    /// <summary>
    /// 汽车工厂抽象
    /// </summary>
    public interface ICarFactory
    {
        /// <summary>
        /// 获取具体汽车
        /// </summary>
        /// <returns></returns>
        ICar GetCar();
    }
}
