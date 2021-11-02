using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.责任链模式
{
    /// <summary>
    /// 具体处理者：总监
    /// </summary>
    public class RDDiretor : AbstractLeader
    {
        public RDDiretor(AbstractLeader next) : base(next)
        {
        }

        public override void Approve(int days)
        {
            if (days > 7)
                Console.WriteLine("总监审批通过...");
            else if (_next != null)
                _next.Approve(days);
            else
                Console.WriteLine("审批不通过...");
            return;
        }
    }
}
