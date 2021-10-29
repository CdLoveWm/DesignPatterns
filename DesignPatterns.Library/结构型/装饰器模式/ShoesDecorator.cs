using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.装饰器模式
{
    public class ShoesDecorator : Decorator
    {
        public ShoesDecorator(IDog dog) : base(dog)
        {
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("为小狗穿上鞋子");
        }
    }
}
