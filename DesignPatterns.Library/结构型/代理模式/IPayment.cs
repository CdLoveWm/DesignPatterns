using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.代理模式
{
    public interface IPayment
    {
        /// <summary>
        /// 支付
        /// </summary>
        void Pay();
    }
}
