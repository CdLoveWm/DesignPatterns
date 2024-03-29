﻿using DesignPatterns.Library.创建型;
using DesignPatterns.Library.创建型.建造者模式;
using DesignPatterns.Library.创建型.抽象工厂;
using DesignPatterns.Library.工厂方法;
using DesignPatterns.Library.工厂模式;
using DesignPatterns.Library.结构型.享元模式;
using DesignPatterns.Library.结构型.代理模式;
using DesignPatterns.Library.结构型.外观模式;
using DesignPatterns.Library.结构型.桥接模式;
using DesignPatterns.Library.结构型.组合模式;
using DesignPatterns.Library.结构型.装饰器模式;
using DesignPatterns.Library.结构型.适配器模式;
using DesignPatterns.Library.行为型.中介者模式;
using DesignPatterns.Library.行为型.命令模式;
using DesignPatterns.Library.行为型.模板方法模式;
using DesignPatterns.Library.行为型.状态模式;
using DesignPatterns.Library.行为型.策略模式;
using DesignPatterns.Library.行为型.观察者模式;
using DesignPatterns.Library.行为型.访问者模式;
using DesignPatterns.Library.行为型.责任链模式;
using DesignPatterns.Library.行为型.迭代器模式;
using DesignPatterns.Library.行为型.迭代器模式.迭代器模式csharp的实现1;
using DesignPatterns.Library.行为型.迭代器模式.迭代器模式csharp的实现2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建型设计模式

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
            //{
            //    IFactory factory = null;
            //    factory = new HuaWeiFactory();
            //    factory.CreateComputer().Show();
            //    factory.CreatePhone().Show();

            //    factory = new XiaoMiFactory();
            //    factory.CreateComputer().Show();
            //    factory.CreatePhone().Show();
            //}
            #endregion

            #region 建造者模式测试
            //{
            //    AbstractBuilder builder = null;
            //    Director director = null;

            //    builder = new NordicStyleBuilder();
            //    director = new Director(builder);
            //    director.GetHouse();
            //    Console.WriteLine("北欧风格装修完成");

            //    builder = new SmartnessStyleBuilder();
            //    director = new Director(builder);
            //    director.GetHouse();
            //    Console.WriteLine("现代风格装修完成");
            //}
            #endregion

            #endregion

            #region 结构型设计模式

            #region 适配器模式
            //{
            //    ITarget5V adpter = new Adapter5V();
            //    adpter.Adapt5V();
            //}
            #endregion

            #region 桥接模式
            //{
            //    IColor color = null;
            //    AbstractShape shape = null;
            //    // 红色矩形
            //    color = new RedColor();
            //    shape = new Rectangle(color);
            //    shape.ShowSpecificShape();
            //    // 黄色矩形
            //    color = new YellowColor();
            //    shape = new Rectangle(color);
            //    shape.ShowSpecificShape();
            //    // 红色圆形
            //    color = new RedColor();
            //    shape = new Circle(color);
            //    shape.ShowSpecificShape();
            //    // 黄色圆形
            //    color = new YellowColor();
            //    shape = new Circle(color);
            //    shape.ShowSpecificShape();


            //}
            #endregion

            #region 代理模式

            //// 之前的微信支付
            //IPayment payment = new WeiXinPayment();
            //payment.Pay();
            //Console.WriteLine("********************");
            //// 代理模式下的微信支付
            //IPayment proxy = new WeiXinPaymentProxy();
            //proxy.Pay();
            #endregion

            #region 装饰器设计模式

            //IDog dog = new Dog();
            //dog.Display();
            //Console.WriteLine("*******************************");

            //IDog clothesDog = new ClothesDecorator(dog);
            //clothesDog.Display();
            //Console.WriteLine("*******************************");

            //IDog shoesDog = new ShoesDecorator(dog);
            //shoesDog.Display();
            //Console.WriteLine("*******************************");

            //IDog allDog = new ShoesDecorator(clothesDog);
            //allDog.Display();
            //Console.WriteLine("*******************************");

            #endregion

            #region 外观模式

            //Waiter waiter = new Waiter();
            //waiter.Order();
            //waiter.AddTea();
            //waiter.AddSoup();

            #endregion

            #region 享元模式

            //string connectionStr = "server=10.21.1.36;user id=sa;password=#123;persistsecurityinfo=True;database=test";
            //IConnection connection1 = ConnectionFactory.GetConnection(connectionStr);
            //connection1.PrintConnectionStr();
            //Console.WriteLine("***************************");
            //IConnection connection2 = ConnectionFactory.GetConnection(connectionStr);
            //connection2.PrintConnectionStr();
            //Console.WriteLine("***************************");
            //IConnection connection3 = ConnectionFactory.GetConnection(connectionStr);
            //connection3.PrintConnectionStr();

            //string connectionStr1 = "server=10.45.11.36;user id=sa;password=12;persistsecurityinfo=True;database=test";
            //IConnection connection4 = ConnectionFactory.GetConnection(connectionStr1);
            //connection1.PrintConnectionStr();
            //Console.WriteLine("***************************");
            //IConnection connection5 = ConnectionFactory.GetConnection(connectionStr1);
            //connection2.PrintConnectionStr();
            //Console.WriteLine("***************************");
            //IConnection connection6 = ConnectionFactory.GetConnection(connectionStr1);
            //connection3.PrintConnectionStr();

            #endregion

            #region 组合模式

            //Folder folder1 = new Folder("文件夹1");
            //Folder folder2 = new Folder("文件夹2");
            //Folder folder3 = new Folder("文件夹3");

            //File file1 = new File("文件1");
            //File file2 = new File("文件2");
            //File file3 = new File("文件3");
            //File file4 = new File("文件4");

            //folder1.Add(file1);
            //folder1.Add(folder2);
            //folder2.Add(folder3);
            //folder2.Add(file2);
            //folder3.Add(file3);
            //folder3.Add(file4);
            //folder1.Show();
            //Console.WriteLine("***********************");  
            //folder3.Remove(file3);
            //folder1.Show();

            #endregion

            #endregion

            #region 行为型设计模式

            #region 模板方法

            //AbstractDrivingExamine shenZhen = new ShenZhenDrivingExamine();
            //shenZhen.Exam();
            //Console.WriteLine("*************************");
            //AbstractDrivingExamine qingYuan = new QingYuanDrivingExamine();
            //qingYuan.Exam();

            #endregion

            #region 策略模式

            //IStrategy airplane = new AirplaneStrategy();
            //Travel travel1 = new Travel(airplane);
            //travel1.Depart();
            //Console.WriteLine("*************************");
            //IStrategy train = new TrainStrategy();
            //Travel travel2 = new Travel(train);
            //travel2.Depart();

            #endregion

            #region 命令模式

            //Television tv = new Television();
            //ICommand startCommand = new StartCommand(tv);
            //RemoteControl control = new RemoteControl(startCommand);
            //control.Action();

            //Console.WriteLine("*************************");

            //ICommand closeCommand = new CloseCommand(tv);
            //RemoteControl control1 = new RemoteControl(closeCommand);
            //control1.Action();

            #endregion

            #region 责任链模式

            //AbstractLeader director = new RDDiretor(null);
            //AbstractLeader manager = new Manager(director);
            //AbstractLeader leader = new DirectLeader(manager);
            //leader.Approve(2);
            //Console.WriteLine("*********************");
            //leader.Approve(5);
            //Console.WriteLine("*********************");
            //leader.Approve(8);

            #endregion

            #region 状态模式

            #region 状态模式-红绿灯

            // 状态按照规则自动流转
            //TrafficLightContext context = new TrafficLightContext();
            //for (int i = 0; i < 10; i++)
            //    context.Run();

            #endregion

            #endregion

            #region 观察者模式

            //CatSubject cat = new CatSubject();
            //IObserver observer = null;
            //observer = new BabyObserver();
            //cat.Observers += observer.Response;
            //observer = new MouseObserver();
            //cat.Observers += observer.Response;
            //observer = new ThiefObserver();
            //cat.Observers += observer.Response;

            //cat.Miao();
            #endregion

            #region 中介者模式

            //AbstractColleague colleague1 = new User1Colleague("100");
            //AbstractColleague colleague2 = new User2Colleague("200");
            //AbstractMediator mediator = new MarriageMediator();
            //mediator.Register(colleague1);
            //mediator.Register(colleague2);
            //colleague1.Send();
            //Console.WriteLine("***************************");
            //colleague2.Send();
            #endregion

            #region 迭代器模式

            #region 迭代器模式自定义实现
            //BookShelfAggregate<string> bookShelf = new BookShelfAggregate<string>();
            //bookShelf.Add("天龙八部");
            //bookShelf.Add("射雕英雄传");
            //bookShelf.Add("神雕侠侣");
            //bookShelf.Add("笑傲江湖");
            //var iterator = bookShelf.GetIterator();
            //while (iterator.HasNext())
            //{
            //    Console.WriteLine(iterator.Next());
            //}
            //Console.WriteLine($"第一本书籍：{iterator.First()}");
            #endregion

            #region 迭代器模式csharp的实现1

            //ColorAggregate color = new ColorAggregate();
            //color.Add("red");
            //color.Add("green");
            //color.Add("yellow");
            //foreach (var item in color)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 迭代器模式csharp的实现2

            //NameAggregate name = new NameAggregate();
            //name.Add("red1");
            //name.Add("green1");
            //name.Add("yellow1");
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion

            #region 访问者模式

            //Extracivilization extracivilization = new Extracivilization();
            //extracivilization.AddElement(new AlienElement());
            //extracivilization.Accept(new BeiJingVisitor());
            //Console.WriteLine("*********************************");
            //extracivilization.Accept(new ZheJiangVisitor());
            //Console.WriteLine("*********************************");
            //extracivilization.Accept(new GuangDongVisitor());

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
