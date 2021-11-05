using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.迭代器模式.迭代器模式csharp的实现1
{
    /// <summary>
    /// 颜色对象集合
    /// </summary>
    public class ColorAggregate : IEnumerable
    {
        private List<string> colors = new();

        public void Add(string color)
        {
            this.colors.Add(color);
        }
        public void Remove(string color)
        {
            this.colors.Remove(color);
        }
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }

        public struct ColorEnumerator : IEnumerator
        {
            private List<string> _datas;
            private int _position;

            public ColorEnumerator(List<string> datas)
            {
                _datas = datas;
                _position = -1;
            }
            public object Current => _position > _datas.Count ? null : _datas[_position];

            public bool MoveNext()
            {
                if (_position < _datas.Count - 1)
                {
                    _position++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _position = -1;
            }
        }
    }
}
