using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace OnlineMonitor.ConfigPanle
{
    class OperatINI
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        //参数说明：section：INI文件中的段落；key：INI文件中的关键字；val：INI文件中关键字的数值；filePath：INI文件的完整的路径和名称。
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        //参数说明：section：INI文件中的段落名称；key：INI文件中的关键字；def：无法读取时候时候的缺省数值；retVal：读取数值；size：数值的大小；filePath：INI文件的完整路径和名称。

        private string sPath = null;
        public OperatINI(string path)
        {
            this.sPath = path;
        }

        public void WriteValue(string section, string key, string value)
        {

            // section=配置节，key=键名，value=键值，path=路径  

            WritePrivateProfileString(section, key, value, sPath);

        }
        public string ReadValue(string section, string key)
        {

            // 每次从ini中读取多少字节  

            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);

            // section=配置节，key=键名，temp=上面，path=路径  

            GetPrivateProfileString(section, key, "", temp, 255, sPath);

            return temp.ToString();

        }


    }
}
