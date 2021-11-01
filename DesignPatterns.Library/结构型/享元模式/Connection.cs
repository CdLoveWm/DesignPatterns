using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.享元模式
{
    /// <summary>
    /// 具体数据库连接对象
    /// </summary>
    public class Connection : IConnection
    {
        // 连接字符串
        private readonly string _connectionStr;
        public Connection(string connectionStr)
        {
            this._connectionStr = connectionStr;
            Console.WriteLine("开始创建连接");
        }
        /// <summary>
        /// 打印连接字符串
        /// </summary>
        public void PrintConnectionStr()
        {
            Console.WriteLine($"The connection string is: {_connectionStr}");
        }
    }
}
