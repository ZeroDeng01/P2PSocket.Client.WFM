namespace P2P.Socket.StartUp_Winform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.DelAllowPortButton = new System.Windows.Forms.Button();
            this.AddAllowPortButton = new System.Windows.Forms.Button();
            this.AllowPortListBox = new System.Windows.Forms.ListBox();
            this.ServerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBaseConfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PortMapItemListBox = new System.Windows.Forms.ListBox();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.AddPortMapItemButton = new System.Windows.Forms.Button();
            this.DelPortMapItemButton = new System.Windows.Forms.Button();
            this.P2PTypeTextBox = new System.Windows.Forms.TextBox();
            this.RemoteAddressTextBox = new System.Windows.Forms.TextBox();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isP2PCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.ForeColor = System.Drawing.Color.Lime;
            this.LogTextBox.Location = new System.Drawing.Point(0, 0);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(726, 197);
            this.LogTextBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LogTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(728, 470);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PortTextBox);
            this.groupBox2.Controls.Add(this.DelAllowPortButton);
            this.groupBox2.Controls.Add(this.AddAllowPortButton);
            this.groupBox2.Controls.Add(this.AllowPortListBox);
            this.groupBox2.Location = new System.Drawing.Point(507, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本机端口开放列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "开放端口号:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(157, 18);
            this.PortTextBox.MaxLength = 5;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(55, 21);
            this.PortTextBox.TabIndex = 9;
            // 
            // DelAllowPortButton
            // 
            this.DelAllowPortButton.Location = new System.Drawing.Point(157, 50);
            this.DelAllowPortButton.Name = "DelAllowPortButton";
            this.DelAllowPortButton.Size = new System.Drawing.Size(55, 24);
            this.DelAllowPortButton.TabIndex = 11;
            this.DelAllowPortButton.Text = "删除";
            this.DelAllowPortButton.UseVisualStyleBackColor = true;
            this.DelAllowPortButton.Click += new System.EventHandler(this.DelAllowPortButton_Click);
            // 
            // AddAllowPortButton
            // 
            this.AddAllowPortButton.Location = new System.Drawing.Point(85, 50);
            this.AddAllowPortButton.Name = "AddAllowPortButton";
            this.AddAllowPortButton.Size = new System.Drawing.Size(55, 24);
            this.AddAllowPortButton.TabIndex = 10;
            this.AddAllowPortButton.Text = "添加";
            this.AddAllowPortButton.UseVisualStyleBackColor = true;
            this.AddAllowPortButton.Click += new System.EventHandler(this.AddAllowPortButton_Click);
            // 
            // AllowPortListBox
            // 
            this.AllowPortListBox.FormattingEnabled = true;
            this.AllowPortListBox.ItemHeight = 12;
            this.AllowPortListBox.Location = new System.Drawing.Point(11, 21);
            this.AllowPortListBox.Name = "AllowPortListBox";
            this.AllowPortListBox.ScrollAlwaysVisible = true;
            this.AllowPortListBox.Size = new System.Drawing.Size(65, 172);
            this.AllowPortListBox.TabIndex = 0;
            // 
            // ServerAddressTextBox
            // 
            this.ServerAddressTextBox.Location = new System.Drawing.Point(85, 18);
            this.ServerAddressTextBox.Name = "ServerAddressTextBox";
            this.ServerAddressTextBox.Size = new System.Drawing.Size(227, 21);
            this.ServerAddressTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器地址:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(401, 18);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(246, 21);
            this.ClientNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户端名称:";
            // 
            // SaveBaseConfig
            // 
            this.SaveBaseConfig.Location = new System.Drawing.Point(653, 17);
            this.SaveBaseConfig.Name = "SaveBaseConfig";
            this.SaveBaseConfig.Size = new System.Drawing.Size(52, 22);
            this.SaveBaseConfig.TabIndex = 4;
            this.SaveBaseConfig.Text = "保存";
            this.SaveBaseConfig.UseVisualStyleBackColor = true;
            this.SaveBaseConfig.Click += new System.EventHandler(this.SaveBaseConfig_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveBaseConfig);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ClientNameTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ServerAddressTextBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "公共配置";
            // 
            // PortMapItemListBox
            // 
            this.PortMapItemListBox.FormattingEnabled = true;
            this.PortMapItemListBox.HorizontalScrollbar = true;
            this.PortMapItemListBox.ItemHeight = 12;
            this.PortMapItemListBox.Location = new System.Drawing.Point(8, 20);
            this.PortMapItemListBox.Name = "PortMapItemListBox";
            this.PortMapItemListBox.ScrollAlwaysVisible = true;
            this.PortMapItemListBox.Size = new System.Drawing.Size(262, 172);
            this.PortMapItemListBox.TabIndex = 1;
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(377, 20);
            this.LocalPortTextBox.MaxLength = 5;
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(110, 21);
            this.LocalPortTextBox.TabIndex = 2;
            // 
            // AddPortMapItemButton
            // 
            this.AddPortMapItemButton.Location = new System.Drawing.Point(377, 164);
            this.AddPortMapItemButton.Name = "AddPortMapItemButton";
            this.AddPortMapItemButton.Size = new System.Drawing.Size(52, 24);
            this.AddPortMapItemButton.TabIndex = 7;
            this.AddPortMapItemButton.Text = "添加";
            this.AddPortMapItemButton.UseVisualStyleBackColor = true;
            this.AddPortMapItemButton.Click += new System.EventHandler(this.AddPortMapItemButton_Click);
            // 
            // DelPortMapItemButton
            // 
            this.DelPortMapItemButton.Location = new System.Drawing.Point(435, 164);
            this.DelPortMapItemButton.Name = "DelPortMapItemButton";
            this.DelPortMapItemButton.Size = new System.Drawing.Size(52, 24);
            this.DelPortMapItemButton.TabIndex = 8;
            this.DelPortMapItemButton.Text = "删除";
            this.DelPortMapItemButton.UseVisualStyleBackColor = true;
            this.DelPortMapItemButton.Click += new System.EventHandler(this.DelPortMapItemButton_Click);
            // 
            // P2PTypeTextBox
            // 
            this.P2PTypeTextBox.Location = new System.Drawing.Point(377, 73);
            this.P2PTypeTextBox.MaxLength = 5;
            this.P2PTypeTextBox.Name = "P2PTypeTextBox";
            this.P2PTypeTextBox.ReadOnly = true;
            this.P2PTypeTextBox.Size = new System.Drawing.Size(110, 21);
            this.P2PTypeTextBox.TabIndex = 4;
            this.P2PTypeTextBox.Text = "1";
            // 
            // RemoteAddressTextBox
            // 
            this.RemoteAddressTextBox.Location = new System.Drawing.Point(377, 102);
            this.RemoteAddressTextBox.MaxLength = 128;
            this.RemoteAddressTextBox.Name = "RemoteAddressTextBox";
            this.RemoteAddressTextBox.Size = new System.Drawing.Size(110, 21);
            this.RemoteAddressTextBox.TabIndex = 5;
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(377, 132);
            this.RemotePortTextBox.MaxLength = 5;
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(110, 21);
            this.RemotePortTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "本地端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "开启P2P:";
            // 
            // isP2PCheckBox
            // 
            this.isP2PCheckBox.AutoSize = true;
            this.isP2PCheckBox.Location = new System.Drawing.Point(378, 50);
            this.isP2PCheckBox.Name = "isP2PCheckBox";
            this.isP2PCheckBox.Size = new System.Drawing.Size(90, 16);
            this.isP2PCheckBox.TabIndex = 3;
            this.isP2PCheckBox.Text = "使用P2P通信";
            this.isP2PCheckBox.UseVisualStyleBackColor = true;
            this.isP2PCheckBox.CheckedChanged += new System.EventHandler(this.isP2PCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "P2P标识:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "对方客户端名称:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "对方开启的端口:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.isP2PCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RemotePortTextBox);
            this.groupBox1.Controls.Add(this.RemoteAddressTextBox);
            this.groupBox1.Controls.Add(this.P2PTypeTextBox);
            this.groupBox1.Controls.Add(this.DelPortMapItemButton);
            this.groupBox1.Controls.Add(this.AddPortMapItemButton);
            this.groupBox1.Controls.Add(this.LocalPortTextBox);
            this.groupBox1.Controls.Add(this.PortMapItemListBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户端连接信息";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(85, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 111);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "声明";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("宋体", 8F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 91);
            this.label9.TabIndex = 0;
            this.label9.Text = "当您设置了开放端口号后，其他用户就可以通过您的客户端名称和开放端口号连接您的计算机。请妥善配置您的端口开放信息。如果您不明白此项配置，请留空。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "P2P内网穿透客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelAllowPortButton;
        private System.Windows.Forms.Button AddAllowPortButton;
        private System.Windows.Forms.ListBox AllowPortListBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveBaseConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerAddressTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isP2PCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.TextBox RemoteAddressTextBox;
        private System.Windows.Forms.TextBox P2PTypeTextBox;
        private System.Windows.Forms.Button DelPortMapItemButton;
        private System.Windows.Forms.Button AddPortMapItemButton;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.ListBox PortMapItemListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
    }
}

