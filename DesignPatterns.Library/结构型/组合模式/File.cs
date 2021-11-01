using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.结构型.组合模式
{
    /// <summary>
    /// 文件（叶子节点）
    /// </summary>
    public class File: IDirectory
    {
        private string fileName;
        public File(string fileName)
        {
            this.fileName = fileName;
        }
        public void Show()
        {
            Console.WriteLine($"这是一个文件，文件名：${fileName}");
        }
    }
}
