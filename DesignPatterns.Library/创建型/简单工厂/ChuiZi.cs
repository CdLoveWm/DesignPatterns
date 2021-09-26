using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂模式
{
    /// <summary>
    /// 锤子手机
    /// </summary>
    public class ChuiZi : AbstracPhone
    {
        protected override string PhoneType => nameof(ChuiZi);
    }
}
