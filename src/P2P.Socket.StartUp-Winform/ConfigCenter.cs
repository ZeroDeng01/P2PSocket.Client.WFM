﻿using P2PSocket.Client.Utils;
using P2PSocket.Core;
using P2PSocket.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace P2PSocket.StartUp_Windows
{

    public class ConfigCenter
    {
        static ConfigCenter m_instance = null;

        public static ConfigCenter Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new ConfigCenter();
                }
                return m_instance;
            }
        }

        internal static void LoadConfig(ConfigCenter config)
        {
            m_instance = config;
        }

        public ConfigCenter()
        {
            Init();
        }

        public void Init()
        {
            ServerAddress = "";
            PortMapList = new List<PortMapItem>();
            ClientName = "";
            AuthCode = "";
            AllowPortList.Clear();
            BlackClients.Clear();
        }
        /// <summary>
        ///     服务器地址
        /// </summary>
        public string ServerAddress { set; get; }
        /// <summary>
        ///     服务器端口
        /// </summary>
        public int ServerPort { set; get; }
        /// <summary>
        ///     TODO:P2P内网穿透超时时间
        /// </summary>
        public const int P2PTimeout = 60000;
        /// <summary>
        ///     本地端口映射（需要启动时初始化）
        /// </summary>
        public List<PortMapItem> PortMapList = new List<PortMapItem>();
        /// <summary>
        ///     客户端服务名
        /// </summary>
        public string ClientName { set; get; }
        /// <summary>
        ///     客户端授权码
        /// </summary>
        public string AuthCode { set; get; }
        /// <summary>
        ///     允许外部连接的端口
        /// </summary>
        public List<AllowPortItem> AllowPortList { get; } = new List<AllowPortItem>();
        /// <summary>
        ///     客户端黑名单
        /// </summary>
        public List<string> BlackClients { get; } = new List<string>();
        /*
        public static string GetConfigText()
        {
            StringBuilder sb = new StringBuilder();
            using (TextWriter tw = new StringWriter(sb))
            {
                tw.WriteLine($"[Common]");
                tw.WriteLine($"ServerAddress={Instance.ServerAddress}:{Instance.ServerPort}");
                tw.WriteLine($"ClientName={Instance.ClientName}");
                if (!string.IsNullOrEmpty(Instance.AuthCode))
                    tw.WriteLine($"AuthCode={Instance.AuthCode}");
                string allowPort = "";
                for (int i = 0; i < Instance.AllowPortList.Count; i++)
                {
                    AllowPortItem item = Instance.AllowPortList[i];
                    if (i != 0)
                    {
                        allowPort += ",";
                    }
                    if (item.MaxValue == item.MinValue)
                    {
                        allowPort += item.MaxValue;
                    }
                    else
                    {
                        allowPort += $"{item.MinValue}-{item.MaxValue}";
                    }
                    if (item.AllowClients.Count > 0)
                    {
                        allowPort += ":" + string.Join("|", item.AllowClients);
                    }

                }
                if (!string.IsNullOrEmpty(allowPort))
                    tw.WriteLine($"AllowPort={allowPort}");
                string blackList = string.Join(",", Instance.BlackClients);
                if (!string.IsNullOrEmpty(blackList))
                    tw.WriteLine($"BlackList={blackList}");
                tw.WriteLine($"LogLevel={Enum.GetName(typeof(Core.Utils.LogLevel), LogUtils.Instance.LogLevel)}");
                if (!string.IsNullOrEmpty(P2PTcpClient.Proxy.IP))
                    tw.WriteLine($"Proxy_Ip={P2PTcpClient.Proxy.IP}");
                if (!string.IsNullOrEmpty(P2PTcpClient.Proxy.UserName))
                    tw.WriteLine($"Proxy_UserName={P2PTcpClient.Proxy.UserName}");
                if (!string.IsNullOrEmpty(P2PTcpClient.Proxy.Password))
                    tw.WriteLine($"Proxy_Password={P2PTcpClient.Proxy.Password}");
                if (Instance.PortMapList.Count > 0)
                {
                    tw.WriteLine($"[PortMapItem]");
                    Instance.PortMapList.ForEach(t =>
                    {
                        string item = (string.IsNullOrEmpty(t.LocalAddress) ? $"{t.LocalPort}" : $"{t.LocalAddress}:{t.LocalPort}") + "->" +
                            (t.MapType == PortMapType.ip ? ($"{t.RemoteAddress}:{t.RemotePort}") : ($"[{t.RemoteAddress}]:{t.RemotePort}"));
                        tw.WriteLine(item);
                    });
                }
            }
            return sb.ToString();
        }
        */
        
    }


}
