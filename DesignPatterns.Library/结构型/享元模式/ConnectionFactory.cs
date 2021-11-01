using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.享元模式
{
    /// <summary>
    /// 数据库连接对象工厂
    /// </summary>
    public class ConnectionFactory
    {
        private static ConcurrentDictionary<string, IConnection> dics = new ConcurrentDictionary<string, IConnection>();
        private static readonly object _lock = new object();
        /// <summary>
        /// 获取连接对象
        /// </summary>
        /// <returns></returns>
        public static IConnection GetConnection(string connectionStr)
        {
            if (string.IsNullOrWhiteSpace(connectionStr)) 
                throw new ArgumentNullException("连接字符串为空");
            connectionStr = connectionStr.Trim();
            if (!dics.ContainsKey(connectionStr))
            {
                lock (_lock)
                {
                    if (!dics.ContainsKey(connectionStr))
                    {
                        IConnection connection = new Connection(connectionStr);
                        dics.TryAdd(connectionStr, connection);
                    }
                }
            }
            return dics[connectionStr];
        }

    }
}
