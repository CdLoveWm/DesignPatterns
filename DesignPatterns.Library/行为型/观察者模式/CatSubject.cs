using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.观察者模式
{
    /// <summary>
    /// 主题--猫
    /// </summary>
    public class CatSubject
    {
        public event Action Observers;

        /// <summary>
        /// 猫叫
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("猫叫了...");
            if(Observers != null)
                Observers.Invoke();
        }
    }
}
