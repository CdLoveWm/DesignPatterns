using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.模板方法模式
{
    /// <summary>
    /// 深圳驾考
    /// </summary>
    public class ShenZhenDrivingExamine : AbstractDrivingExamine
    {
        public override bool Subject2()
        {
            Console.WriteLine("考试科二：倒车入库、侧方停车、S弯、直角转弯、定点停车与起步");
            return true;
        }
        public override bool Subject3()
        {
            Console.WriteLine("考试科三：起步、超车、变道、直线行驶......靠边停车");
            return true;
        }
    }
}
