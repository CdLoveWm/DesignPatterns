using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.工厂模式
{
    public abstract class AbstracPhone
    {
        /// <summary>
        /// 电话类型
        /// </summary>
        protected abstract string PhoneType { get;}
        /// <summary>
        /// 打电话
        /// </summary>
        public virtual void Call()
        {
            Console.WriteLine($"使用{PhoneType}打电话");
        }
    }
}
