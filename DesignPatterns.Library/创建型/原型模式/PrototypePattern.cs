using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型
{
    /// <summary>
    /// 原型模式--浅拷贝
    /// </summary>
    public class PrototypePattern
    {
        private static PrototypePattern _instance = null;
        private PrototypePattern() { }
        static PrototypePattern()
        {
            _instance = new PrototypePattern();
        }
        /// <summary>
        /// 直接克隆
        /// </summary>
        /// <returns></returns>
        public static PrototypePattern Clone()
        {
            return _instance.MemberwiseClone() as PrototypePattern;
        }
        public void Show()
        {
            Console.WriteLine("Prototype Pattern");
        }
    }

    /// <summary>
    /// 测试MemberwiseClone为浅拷贝，对于引用类型的成员变量只会拷贝其对应引用地址。而不会创建一个对应的新的应用类型的实例
    /// </summary>
    public class Prototype
    {
        public List<string> Codes = new List<string>();
        public Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
    /// <summary>
    /// 重新初始化引用类型的成员，达到深拷贝的目的
    /// </summary>
    public class Prototype2
    {
        public List<string> Codes = new List<string>();
        public Prototype2 Clone()
        {
            Prototype2 instance = this.MemberwiseClone() as Prototype2;
            if (instance != null)
                // 这里重新初始化字段Codes
                instance.Codes = new List<string>();
            return instance;
        }
    }
}
