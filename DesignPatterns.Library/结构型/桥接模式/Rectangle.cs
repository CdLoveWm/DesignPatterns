using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.桥接模式
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle : AbstractShape
    {
        public Rectangle(IColor color) : base(color)
        {
        }
        public override void ShowSpecificShape()
        {
            Console.WriteLine($"{color.GetColor()}矩形");
        }
    }
}
