using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.命令模式
{
    /// <summary>
    /// 命令接收者-电视机
    /// </summary>
    public class Television
    {
        public void Start()
        {
            Console.WriteLine("电视开机");
        }
        public void Close() 
        {
            Console.WriteLine("电视关机");    
        }
    }
}
