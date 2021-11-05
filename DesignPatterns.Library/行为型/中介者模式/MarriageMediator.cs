using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.行为型.中介者模式
{
    /// <summary>
    /// 具体中介角色-婚姻介绍所
    /// </summary>
    public class MarriageMediator : AbstractMediator
    {
        private List<AbstractColleague> colleagues = new();
        /// <summary>
        /// 婚介所介绍
        /// </summary>
        /// <param name="code">人员编号</param>
        public override void Introduce(string code)
        {
            Console.WriteLine("婚介所开始连线搭桥...");
            colleagues.FirstOrDefault(it => it.Code == code)?.Reveive();
        }

        /// <summary>
        /// 注册相亲人员
        /// </summary>
        /// <param name="colleague"></param>
        public override void Register(AbstractColleague colleague)
        {
            // 注册进婚介所
            colleagues.Add(colleague);
            // 将婚介所聚合赋值到具体人员（相当于现实中将婚介所的联系方式给到注册人）
            colleague.SetMediator(this);
        }
    }
}
