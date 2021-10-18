using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.代理模式
{
    /// <summary>
    /// 支付代理
    /// </summary>
    public class WeiXinPaymentProxy : IPayment
    {
        private WeiXinPayment weiXin = new WeiXinPayment();

        /// <summary>
        /// 权限验证
        /// </summary>
        public void Authorize()
        {
            Console.WriteLine("验证成功");
        }

        public void Pay()
        {
            this.Authorize();
            weiXin.Pay();
            this.Log();
        }
        /// <summary>
        /// 日志记录
        /// </summary>
        public void Log()
        {
            Console.WriteLine("记录日志：支付成功");
        }
    }
}
