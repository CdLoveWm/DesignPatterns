using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.责任链模式
{
    /// <summary>
    /// 具体处理者： 直属领导
    /// </summary>
    public class DirectLeader : AbstractLeader
    {
        public DirectLeader(AbstractLeader next) : base(next)
        {
        }
        /// <summary>
        /// 审批
        /// </summary>
        /// <param name="days"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Approve(int days)
        {
            if (days < 3)
                Console.WriteLine("直属领导审批通过...");
            else if (_next != null)
                _next.Approve(days);
            else
                Console.WriteLine("审批不通过...");
            return;
        }
    }
}
