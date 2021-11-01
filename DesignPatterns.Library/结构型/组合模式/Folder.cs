using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.组合模式
{
    /// <summary>
    /// 文件夹
    /// </summary>
    public class Folder : IDirectory
    {
        private string _folderName;
        private List<IDirectory> _childrens = new List<IDirectory>();
        public Folder(string folderName)
        {
            _folderName = folderName;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="directory"></param>
        public void Add(IDirectory directory)
        {
            _childrens.Add(directory);
        }
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="directory"></param>
        public void Remove(IDirectory directory)
        {
            if (_childrens.Contains(directory))
                _childrens.Remove(directory);
        }
        /// <summary>
        /// 获取子节点
        /// </summary>
        /// <returns></returns>
        public List<IDirectory> GetChildren()
        {
            return _childrens;
        }
        public void Show()
        {
            Console.WriteLine($"这是一个文件夹：{_folderName}");
            foreach (var item in _childrens)
            {
                item.Show();
            }
        }
    }
}
