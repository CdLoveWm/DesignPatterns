using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂模式
{
    /// <summary>
    /// 华为手机
    /// </summary>
    public class HuaWei : AbstracPhone
    {
        protected override string PhoneType => nameof(HuaWei);
    }
}
