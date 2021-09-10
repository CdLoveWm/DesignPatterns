using DesignPatterns.Library.创建型;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 原型模式
            // 浅拷贝测试
            {
                Prototype prototype1 = new Prototype();
                Prototype prototype2 = prototype1.Clone();
                prototype1.Codes.Add("01");
                prototype1.Codes.Add("02");
                prototype2.Codes.Add("03");
                prototype2.Codes.Add("04");

                Console.WriteLine($"prototype1.Codes--->{string.Join(", ", prototype1.Codes)}");
                Console.WriteLine($"prototype2.Codes--->{string.Join(", ", prototype2.Codes)}");
            }

            // 深拷贝
            {
                Prototype2 prototype1 = new Prototype2();
                Prototype2 prototype2 = prototype1.Clone();
                prototype1.Codes.Add("01");
                prototype1.Codes.Add("02");
                prototype2.Codes.Add("03");
                prototype2.Codes.Add("04");

                Console.WriteLine($"prototype1.Codes--->{string.Join(", ", prototype1.Codes)}");
                Console.WriteLine($"prototype2.Codes--->{string.Join(", ", prototype2.Codes)}");
            }
            #endregion

            string[] aa = null;
            var a = aa.AsEnumerable();

            Console.WriteLine("Hello World!");
        }
    }
}
