using DesignPatterns.Library.创建型;
using DesignPatterns.Library.创建型.抽象工厂;
using DesignPatterns.Library.工厂方法;
using DesignPatterns.Library.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 原型模式测试

            #region 浅拷贝测试
            //{
            //    Prototype prototype1 = new Prototype();
            //    Prototype prototype2 = prototype1.Clone();
            //    prototype1.Codes.Add("01");
            //    prototype1.Codes.Add("02");
            //    prototype2.Codes.Add("03");
            //    prototype2.Codes.Add("04");

            //    Console.WriteLine($"prototype1.Codes--->{string.Join(", ", prototype1.Codes)}");
            //    Console.WriteLine($"prototype2.Codes--->{string.Join(", ", prototype2.Codes)}");
            //}
            #endregion

            #region 深拷贝测试
            //{
            //    Prototype2 prototype1 = new Prototype2();
            //    Prototype2 prototype2 = prototype1.Clone();
            //    prototype1.Codes.Add("01");
            //    prototype1.Codes.Add("02");
            //    prototype2.Codes.Add("03");
            //    prototype2.Codes.Add("04");

            //    Console.WriteLine($"prototype1.Codes--->{string.Join(", ", prototype1.Codes)}");
            //    Console.WriteLine($"prototype2.Codes--->{string.Join(", ", prototype2.Codes)}");
            //}
            #endregion

            #endregion

            #region 简单工厂测试

            #region 不使用工厂
            //AbstracPhone huaWei = new HuaWei();
            //huaWei.Call();
            //AbstracPhone xiaoMi = new XiaoMi();
            //xiaoMi.Call();
            #endregion

            #region 使用简单工厂
            //AbstracPhone huaWei = SimpleFactory.CreatePhone(PhoneTypeEnum.HuaWei);
            //huaWei.Call();
            //AbstracPhone xiaoMi = SimpleFactory.CreatePhone(PhoneTypeEnum.XiaoMi);
            //xiaoMi.Call();
            #endregion
            #endregion

            #region 工厂方法测试
            //{
            //    // 比亚迪工厂造比亚迪汽车
            //    ICarFactory bydFactory = new BydFactory();
            //    bydFactory.GetCar().ShowCar();
            //    // 哈佛工厂造哈佛汽车
            //    ICarFactory havalFactory = new HavalFactory();
            //    havalFactory.GetCar().ShowCar();
            //}
            #endregion

            #region 抽象工厂模式测试
            {
                IFactory factory = null;
                factory = new HuaWeiFactory();
                factory.CreateComputer().Show();
                factory.CreatePhone().Show();

                factory = new XiaoMiFactory();
                factory.CreateComputer().Show();
                factory.CreatePhone().Show();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
