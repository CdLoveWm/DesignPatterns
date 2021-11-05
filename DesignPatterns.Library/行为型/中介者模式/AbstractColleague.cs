using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.中介者模式
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class AbstractColleague
    {
        // 聚合中介者角色
        public AbstractMediator _mediator;
        // 人员编号，唯一
        public string Code { get; }
        public AbstractColleague(string code)
        {
            Code = code;
        }
        /// <summary>
        /// 设置中介者
        /// </summary>
        /// <param name="mediator"></param>
        public void SetMediator(AbstractMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// 接收到认识邀请
        /// </summary>
        public abstract void Reveive();
        /// <summary>
        /// 发送认识邀请
        /// </summary>
        public abstract void Send();
    }
}
