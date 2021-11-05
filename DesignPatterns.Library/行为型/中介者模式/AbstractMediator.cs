using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.中介者模式
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class AbstractMediator
    {
        /// <summary>
        /// 注册人员
        /// </summary>
        /// <param name="colleague"></param>
        public abstract void Register(AbstractColleague colleague);
        /// <summary>
        /// 介绍给对方认识，转发请求
        /// </summary>
        /// <param name="colleagueTo">对方人员编号</param>
        public abstract void Introduce(string code);
    }
}
