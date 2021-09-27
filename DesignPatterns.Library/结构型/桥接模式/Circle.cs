using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.桥接模式
{
    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : AbstractShape
    {
        public Circle(IColor color) : base(color)
        {
        }
        public override void ShowSpecificShape()
        {
            Console.WriteLine($"{color.GetColor()}圆形");
        }
    }
}
