using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式
{
    /// <summary>
    /// 具体聚合 -- 书架
    /// </summary>
    public class BookShelfAggregate<T> : IAggregate<T>
    {
        private List<T> books = new ();

        public void Add(T data)
        {
            books.Add(data);
        }
        public void Remove(T data)
        {
            books.Remove(data);
        }
        public Iterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(books);
        }
    }
}
