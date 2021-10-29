using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.装饰器模式
{
    /// <summary>
    /// 衣服装饰
    /// </summary>
    public class ClothesDecorator : Decorator
    {
        public ClothesDecorator(IDog dog) : base(dog)
        {
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("为小狗穿上衣服"); ;
        }
    }
}
