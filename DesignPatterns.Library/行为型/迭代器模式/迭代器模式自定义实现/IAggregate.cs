using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式
{
    /// <summary>
    /// 抽象聚合角色，实现该接口表名是一个聚合类
    /// </summary>
    public interface IAggregate<T>
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data);
        /// <summary>
        /// 移除数据
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data);
        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        public Iterator<T> GetIterator();
    }
}
