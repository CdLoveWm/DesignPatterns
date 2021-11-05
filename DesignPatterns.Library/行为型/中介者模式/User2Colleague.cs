using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.中介者模式
{
    /// <summary>
    /// 具体同事类角色 -- 张三
    /// </summary>
    public class User2Colleague : AbstractColleague
    {
        public User2Colleague(string code) : base(code)
        {
        }
        /// <summary>
        /// 收到消息
        /// </summary>
        public override void Reveive()
        {
            Console.WriteLine("李四收到认识邀请...");
        }

        public override void Send()
        {
            Console.WriteLine("李四看上了一个人，发出认识邀请...");
            _mediator.Introduce("100");
        }
    }
}
