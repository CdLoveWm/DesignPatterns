using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.外观模式
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        private Order order;
        private Soup soup;
        private Tea tea;
        public Waiter()
        {
            order = new Order();
            soup = new Soup();
            tea = new Tea();
        }
        /// <summary>
        /// 点餐
        /// </summary>
        public void Order()
        {
            order.Excute();
        }
        /// <summary>
        /// 加汤
        /// </summary>
        public void AddSoup()
        {
            soup.AddSoup();
        }
        /// <summary>
        /// 添茶
        /// </summary>
        public void AddTea()
        {
            tea.AddTea();
        }
    }
}
