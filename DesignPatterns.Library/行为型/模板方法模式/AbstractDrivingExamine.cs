using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.模板方法模式
{
    /// <summary>
    /// 驾考抽象模板类
    /// </summary>
    public abstract class AbstractDrivingExamine
    {
        /// <summary>
        /// 控制具体的考试顺序
        /// 每前一科过了才能继续考试下一科
        /// </summary>
        public void Exam()
        {
            bool res1 = Subject1();
            bool res2 = false;
            if (res1)
                res2 = Subject2();
            bool res3 = false;
            if (res2)
                res3 = Subject3();
            if (res3)
                Subject4();
        }
        /// <summary>
        /// 科一是固定的，在父类实现
        /// </summary>
        public bool Subject1()
        {
            Console.WriteLine("科一考试...");
            return true;
        }
        /// <summary>
        /// 科二不固定，交由子类具体实现
        /// </summary>
        public abstract bool Subject2();
        /// <summary>
        /// 科三不固定，交由子类具体实现
        /// </summary>
        public abstract bool Subject3();
        /// <summary>
        /// 科四是固定的，在父类实现
        /// </summary>
        public bool Subject4()
        {
            Console.WriteLine("科四考试...");
            return true;
        }

    }
}
