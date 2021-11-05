using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式.迭代器模式csharp的实现2
{
    /// <summary>
    /// 姓名集合
    /// </summary>
    public class NameAggregate: IEnumerable
    {
        private List<string> names = new();
        public void Add(string color)
        {
            this.names.Add(color);
        }
        public void Remove(string color)
        {
            this.names.Remove(color);
        }
        /// <summary>
        /// 编译器会自动帮我们生成IEnumerator内部的Current,MoveNext和Reset方法
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Count; i++)
                yield return names[i];
        }
    }
}
