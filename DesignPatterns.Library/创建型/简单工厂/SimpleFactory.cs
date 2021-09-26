using DesignPatterns.Library.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型
{
    /// <summary>
    /// 简单工厂
    /// 不属于GOF23
    /// 将对象的创建封装到一个工厂类里面
    /// 现有华为、小米、锤子手机三个手机类型。在不使用工厂统一创建之前，对于每个手机类型的对象都是通过直接new
    /// 这里简单工厂只是把手机对象的创建封装到一个类中，如下
    /// </summary>
    public class SimpleFactory
    {
        /// <summary>
        /// 统一根据传入手机类型创建手机对象
        /// </summary>
        /// <param name="phoneType"></param>
        /// <returns></returns>
        public static AbstracPhone CreatePhone(PhoneTypeEnum phoneType)
        {
            AbstracPhone phone = null;
            switch (phoneType)
            {
                case PhoneTypeEnum.HuaWei:
                    phone = new HuaWei();
                    break;
                case PhoneTypeEnum.XiaoMi:
                    phone = new XiaoMi();
                    break;
                case PhoneTypeEnum.ChuiZi:
                    phone = new ChuiZi();
                    break;
                default:
                    break;
            }
            return phone;
        }
    }
}
