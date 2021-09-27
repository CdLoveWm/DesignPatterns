using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.桥接模式
{
    /// <summary>
    /// 具体实现-红色
    /// </summary>
    public class RedColor : IColor
    {
        public string GetColor()
        {
            return "红色";
        }
    }
}
