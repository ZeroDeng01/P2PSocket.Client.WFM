using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P2PSocket.StartUp_Windows
{
    public static class Config
    {
        /// <summary>
        /// 运行目录
        /// </summary>
        public static string RuntimePath = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// 配置文件
        /// </summary>
        public static string ConfigFile = Path.Combine(RuntimePath, "P2PSocket", "Client.ini");

        public static bool IsExistConfig()
        {
            return File.Exists(ConfigFile);
        }

    }
}
