using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.享元模式
{
    /// <summary>
    /// 抽象享元（FlyWeight）
    /// 数据库连接抽象
    /// </summary>
    public interface IConnection
    {
        /// <summary>
        /// 打印连接字符串
        /// </summary>
        void PrintConnectionStr();
    }
}
