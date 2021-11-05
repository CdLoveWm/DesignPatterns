using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式
{
    /// <summary>
    /// 迭代器抽象
    /// </summary>
    public interface Iterator<T>
    {
        /// <summary>
        /// 第一个
        /// </summary>
        /// <returns></returns>
        public T First();
        /// <summary>
        /// 返回当前项数据，指向下一项数据
        /// </summary>
        /// <returns></returns>
        public T Next();
        /// <summary>
        /// 是否还有下一项
        /// </summary>
        /// <returns></returns>
        public bool HasNext();
    }
}
