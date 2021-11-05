using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式
{
    /// <summary>
    /// 具体迭代器
    /// </summary>
    public struct ConcreteIterator<T> : Iterator<T>
    {
        private int _pos;
        private readonly List<T> _datas;
        public ConcreteIterator(List<T> datas)
        {
            if (datas == null || datas.Count == 0)
                throw new ArgumentNullException();
            _datas = datas;
            _pos = -1;
        }
        public T First()
        {
            return _datas[0];
        }
        public bool HasNext()
        {
            if (_pos < _datas.Count - 1)
                return true;
            return false;
        }

        public T Next()
        {
            T val = default(T);
            if (HasNext())
                val = _datas[++_pos];
            return val;
        }
    }
}
