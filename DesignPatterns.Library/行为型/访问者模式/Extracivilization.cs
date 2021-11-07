using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.访问者模式
{
    /// <summary>
    /// 对象结构角色 -- 外星文明 
    /// </summary>
    public class Extracivilization
    {
        private List<IElement> elements = new();
        /// <summary>
        /// 添加具体元素
        /// </summary>
        public void AddElement(IElement element) 
        {
            elements.Add(element);
        }
        /// <summary>
        /// 移除具体元素
        /// </summary>
        /// <param name="element"></param>
        public void RemoveElement(IElement element)
        {
            elements.Remove(element);
        }
        /// <summary>
        /// 接受访问者对具体元素进行访问
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            elements.ForEach(it => it.Accept(visitor));
        }
    }
}
