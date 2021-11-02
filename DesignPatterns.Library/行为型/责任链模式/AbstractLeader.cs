using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.责任链模式
{
    /// <summary>
    /// 抽象处理者-抽象领导
    /// </summary>
    public abstract class AbstractLeader
    {
        // 下一审判者
        protected readonly AbstractLeader _next;
        public AbstractLeader(AbstractLeader next)
        {
            this._next = next;
        }
        /// <summary>
        /// 审批
        /// </summary>
        public abstract void Approve(int days);
    }
}
