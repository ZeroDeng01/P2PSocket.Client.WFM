using P2PSocket.Client;
using P2PSocket.Client.Utils;
using P2PSocket.Core.Models;
using P2PSocket.Core.Utils;
using P2PSocket.StartUp_Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace P2P.Socket.StartUp_Winform
{
    public partial class Form1 : Form
    {

        IniFile ini = new IniFile(Config.ConfigFile);
        CoreModule clientModule = new CoreModule();
        private static BindingList<string> allowPorts = new BindingList<string>();
        private static BindingList<string> portMapItems = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            try
            {
                this.Text = this.Text + "-" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch {
                this.Text = this.Text + "-Debug";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LogTextBox.AppendText("\r\n");
            LogTextBox.AppendText("************************************************************************\r\n");
            LogTextBox.AppendText("*              P2P内网穿透桌面客户端   作者：ZeroDeng                  *\r\n");
            LogTextBox.AppendText("*              需要更专业的配置请自行手动修改配置文件                  *\r\n");
            LogTextBox.AppendText("*              感谢内核作者:wireboy                                    *\r\n");
            LogTextBox.AppendText("*              有好的建议或者意见请移步github提交issues                *\r\n");
            LogTextBox.AppendText("*  客户端github地址:https://github.com/ZeroDeng01/P2PSocket.Client.WFM *\r\n");
            LogTextBox.AppendText("************************************************************************\r\n");
            LogTextBox.AppendText("\r\n");

            if (Config.IsExistConfig())
            {
                //加载服务端地址
                ServerAddressTextBox.Text = ini.IniReadValue("Common", "ServerAddress");
                //加载客户端名称
                string clientName = ini.IniReadValue("Common", "ClientName");
                if (clientName.Trim().Length > 0)
                {
                    ClientNameTextBox.Text = clientName;
                }
                else {
                    clientName = BitConverter.ToUInt32(Guid.NewGuid().ToByteArray(), 8).ToString();

                    ClientNameTextBox.Text = clientName;
                    ini.IniWriteValue("Common", "ClientName", clientName);
                }

                //加载被控端口
                string allowPortStr= ini.IniReadValue("Common", "AllowPort");
                if (!"".Equals(allowPortStr)) {
                    if (allowPortStr.IndexOf(',') != -1)
                    {
                        allowPorts = new BindingList<string>(allowPortStr.Split(',').ToList());
                    }
                    else {
                        allowPorts.Add(allowPortStr);
                    }
                }

                AllowPortListBox.DataSource = allowPorts;

                //初始化日志回调
                LogUtils.ClientRecordLogHandler = Instance_RecordLogEvent;
                //初始启动P2PSocket

                clientModule.Start();

                ConfigCenter.Instance.PortMapList.ForEach(t =>
                {
                    string localAddress = string.IsNullOrEmpty(t.LocalAddress) ? "127.0.0.1" : t.LocalAddress;
                    string clientAddress = (t.P2PType == 0) ? ($"[{t.RemoteAddress}]:{t.RemotePort}") : ($"{t.P2PType}@[{t.RemoteAddress}]:{t.RemotePort}");
                    string portMapItemStr = ($"{localAddress}:{t.LocalPort}->{clientAddress}");
                    portMapItems.Add(portMapItemStr);
                });
                PortMapItemListBox.DataSource = portMapItems;

                

            }
            else {
                Log("配置文件缺失，正在创建");
                if (!Directory.Exists(Config.RuntimePath))  //不存在文件夹，创建
                {
                    Directory.CreateDirectory(Config.RuntimePath);  //创建新的文件夹
                }
                FileStream fs = File.Create(Config.ConfigFile);  //创建文件
                fs.Close();
                Log("配置文件创建完毕");
                Form1_Load( sender,  e);
            }
        }
        public void Instance_RecordLogEvent(System.IO.StreamWriter ss, LogInfo logInfo)
        {
            if (LogUtils.Instance.LogLevel >= logInfo.LogLevel)
            {
                Log(logInfo.Msg);
            }
        }

        private void Log(string msg) {
            this.BeginInvoke((MethodInvoker)delegate
            {
                LogTextBox.AppendText("Client > " + msg + "\r\n");
            });
        }

        /// <summary>
        /// 修改基础配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBaseConfig_Click(object sender, EventArgs e)
        {
            if (ServerAddressTextBox.Text.Length > 0)
            {
                ini.IniWriteValue("Common", "ServerAddress", ServerAddressTextBox.Text);
                Log("保存服务器地址成功");
            }
            else {
                ServerAddressTextBox.Text = ini.IniReadValue("Common", "ServerAddress");
            }
            if (ClientNameTextBox.Text.Length > 0)
            {
                ini.IniWriteValue("Common", "ClientName", ClientNameTextBox.Text);
                Log("保存客户端名称成功");
            }
            else {
                ClientNameTextBox.Text = ini.IniReadValue("Common", "ClientName");
            }
            
        }

        /// <summary>
        /// 添加AllowPort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAllowPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(PortTextBox.Text);
                if (port > 65535 || port < 0)
                {
                    MessageBox.Show("端口不合法，端口应该再0~65535之间", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (allowPorts.Contains(port.ToString())) { 
                        MessageBox.Show("端口端口已经存在","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    allowPorts.Add(port.ToString()) ;
                    string[] ports = allowPorts.ToArray();
                    ini.IniWriteValue("Common", "AllowPort", string.Join(",", ports));
                    PortTextBox.Text = "";
                }
            }
            catch { 
                    MessageBox.Show("端口不合法，端口应该再0~65535之间","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 删除AllowPort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelAllowPortButton_Click(object sender, EventArgs e)
        {
            if (AllowPortListBox.SelectedIndex>-1) {
                string port = AllowPortListBox.SelectedItem.ToString();
                allowPorts.Remove(port);
                string[] ports = allowPorts.ToArray();
                ini.IniWriteValue("Common", "AllowPort", string.Join(",", ports));
            }
            
        }

        private void DelPortMapItemButton_Click(object sender, EventArgs e)
        {
            if (PortMapItemListBox.SelectedIndex > -1)
            {
                string portMapItem = PortMapItemListBox.SelectedItem.ToString();
               
                if (ini.Del(portMapItem)) {
                    portMapItems.Remove(portMapItem);
                };
            }

        }

        private void isP2PCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isP2PCheckBox.Checked)
            {
                P2PTypeTextBox.ReadOnly = false;
            }
            else {
                P2PTypeTextBox.ReadOnly = true;
            }
            
        }

        private void AddPortMapItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int localPort = int.Parse(LocalPortTextBox.Text);
                int remotePort = int.Parse(RemotePortTextBox.Text);
                string Conf = "";
                string ConfUI = "";
                if (isP2PCheckBox.Checked)
                {
                    Conf = localPort + "->" + P2PTypeTextBox.Text + "@" + "[" + RemoteAddressTextBox.Text + "]:" + remotePort;
                    ConfUI = "127.0.0.1:"+localPort + "->" + P2PTypeTextBox.Text + "@" + "[" + RemoteAddressTextBox.Text + "]:" + remotePort;
                }
                else {
                    Conf = localPort + "->" + "[" + RemoteAddressTextBox.Text + "]:" + remotePort;
                    ConfUI = "127.0.0.1:"+localPort + "->" + "[" + RemoteAddressTextBox.Text + "]:" + remotePort;
                }
                if (ini.Add(Conf)) {
                    portMapItems.Add(ConfUI);
                    MessageBox.Show($"客户端信息添加成功：\r\n您现在可以通过访问本地地址【127.0.0.1:{localPort}】以请求远程主机【{ RemoteAddressTextBox.Text}:{remotePort}】", "添加客户端信息成功");
                }
            }
            catch
            {
                MessageBox.Show("端口不合法，端口应该再0~65535之间", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
