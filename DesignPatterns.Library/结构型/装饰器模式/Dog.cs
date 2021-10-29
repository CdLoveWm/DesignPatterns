using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.装饰器模式
{
    public class Dog : IDog
    {
        public void Display()
        {
            Console.WriteLine("一只小狗");
        }
    }
}
