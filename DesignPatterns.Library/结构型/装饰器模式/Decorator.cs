using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.装饰器模式
{
    public abstract class Decorator : IDog
    {
        private IDog _dog;
        public Decorator(IDog dog)
        {
            _dog = dog;
        }
        public virtual void Display()
        {
            _dog.Display();
        }
    }
}
