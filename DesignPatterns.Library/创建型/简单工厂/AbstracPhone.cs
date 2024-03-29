﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.工厂模式
{
    /// <summary>
    /// 抽象手机类
    /// </summary>
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
