using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.工厂模式
{
    /// <summary>
    /// 小米手机
    /// </summary>
    public class XiaoMi : AbstracPhone
    {
        protected override string PhoneType => nameof(XiaoMi);
    }
}
