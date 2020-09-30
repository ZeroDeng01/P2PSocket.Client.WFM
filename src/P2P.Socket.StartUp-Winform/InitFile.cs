using P2PSocket.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P2P.Socket.StartUp_Winform
{
    /// <summary>
    /// INI文件的操作类
    /// </summary>
    public class IniFile
    {
        public string Path;

        public IniFile(string path)
        {
            this.Path = path;
        }

        #region 声明读写INI文件的API函数

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);

        #endregion

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <param name="iValue">值</param>
        public void IniWriteValue(string section, string key, string iValue)
        {
            WritePrivateProfileString(section, key, iValue, this.Path);
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <returns>返回的键值</returns>
        public string IniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp.ToString();
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="Section">段，格式[]</param>
        /// <param name="Key">键</param>
        /// <returns>返回byte类型的section组或键值组</returns>
        public byte[] IniReadValues(string section, string key)
        {
            byte[] temp = new byte[255];

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp;
        }

        public bool Del(string value) {
            try
            {
                if (value.IndexOf("127.0.0.1") != -1) {
                    value = value.Replace("127.0.0.1:", "");
                }
                var str = System.IO.File.ReadAllText(this.Path);
                str = str.Replace(value + "\r\n", "");
                str = str.Replace(value, "");
                System.IO.File.WriteAllText(this.Path, str);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool Add(string value)
        {
            try
            {
                var str = System.IO.File.ReadAllText(this.Path);
                int mapIndex = str.IndexOf("[PortMapItem]");
                Console.WriteLine(mapIndex);
                if (mapIndex != -1)
                {
                    str = str.Insert(mapIndex + 13, "\r\n" + value);
                }
                else {
                    str = str + "\r\n[PortMapItem]" + "\r\n" + value;
                }
                System.IO.File.WriteAllText(this.Path, str);
                Console.WriteLine("配置写入成功");
                return true;
            }
            catch
            {
                Console.WriteLine("配置写入失败");
                return false;
            }

        }


        /// <summary>
        /// 获取所有映射信息
        /// </summary>
        /// <returns></returns>
        public List<string> GetPortMapItems(){
            List<string> vs = new List<string>();
            try
            {
                var str = System.IO.File.ReadAllText(this.Path);
                str = str.Replace("[PortMapItem]","*");
                string[] temp = str.Split('*');
                temp = temp[1].Split(Environment.NewLine.ToCharArray());
                
                foreach (string s in temp) {
                    if (s.Length > 0) {

                        vs.Add(s);
                    }
                }

            }
            catch
            {
                Console.WriteLine("配置写入失败");
                return null;
            }
            return vs;
        }



    }
}
