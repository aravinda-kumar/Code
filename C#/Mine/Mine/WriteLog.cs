using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
     static class WriteLog
    {
        //创建写入日志文件
        static public void WriteToLogFile(string fileFullName, string message)
        {
            //获取当前执行文件所在路径
            string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + fileFullName;
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(LogPath, true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + message);
            }
        }
    }
}
