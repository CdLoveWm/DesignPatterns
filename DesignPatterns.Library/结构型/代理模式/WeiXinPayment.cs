using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.代理模式
{
    /// <summary>
    /// 微信支付
    /// </summary>
    public class WeiXinPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("微信支付");
        }
    }
}
