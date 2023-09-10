
namespace PlcTcp
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_connect = new System.Windows.Forms.Button();
			this.tb_plc_port = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_plc_ip = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.tb_send_data = new System.Windows.Forms.TextBox();
			this.btn_startServer = new System.Windows.Forms.Button();
			this.tb_server_port = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_server_ip = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.mqtt_tip = new System.Windows.Forms.Label();
			this.btn_mqtt_start = new System.Windows.Forms.Button();
			this.btn_mqtt_stop = new System.Windows.Forms.Button();
			this.tb_mqtt_port = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_mqtt_ip = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tb_mqtt_client_tip = new System.Windows.Forms.TextBox();
			this.tb_account = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_Client_Link_IP = new System.Windows.Forms.TextBox();
			this.btn_matt_Connect = new System.Windows.Forms.Button();
			this.btn_mqtt_disconnect = new System.Windows.Forms.Button();
			this.tb_connect_port = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textShow1 = new PlcTcp.TextShow();
			this.textShow2 = new PlcTcp.TextShow();
			this.btn_publish = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 38);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1042, 701);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textShow1);
			this.tabPage1.Controls.Add(this.bindingNavigator1);
			this.tabPage1.Controls.Add(this.btn_connect);
			this.tabPage1.Controls.Add(this.tb_plc_port);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.tb_plc_ip);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1034, 668);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Client";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(1028, 25);
			this.bindingNavigator1.TabIndex = 5;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "新添";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
			this.bindingNavigatorCountItem.Text = "/ {0}";
			this.bindingNavigatorCountItem.ToolTipText = "总项数";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "删除";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "位置";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(686, 44);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(72, 35);
			this.btn_connect.TabIndex = 4;
			this.btn_connect.Text = "连接";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// tb_plc_port
			// 
			this.tb_plc_port.Location = new System.Drawing.Point(484, 53);
			this.tb_plc_port.Name = "tb_plc_port";
			this.tb_plc_port.Size = new System.Drawing.Size(150, 26);
			this.tb_plc_port.TabIndex = 3;
			this.tb_plc_port.Text = "2000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(396, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "PLC-端口号";
			// 
			// tb_plc_ip
			// 
			this.tb_plc_ip.Location = new System.Drawing.Point(140, 53);
			this.tb_plc_ip.Name = "tb_plc_ip";
			this.tb_plc_ip.Size = new System.Drawing.Size(150, 26);
			this.tb_plc_ip.TabIndex = 1;
			this.tb_plc_ip.Text = "192.168.2.20";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "PLC-IP地址";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.tb_send_data);
			this.tabPage2.Controls.Add(this.btn_startServer);
			this.tabPage2.Controls.Add(this.tb_server_port);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.tb_server_ip);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textShow2);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1034, 668);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Server";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(449, 254);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 39);
			this.button1.TabIndex = 12;
			this.button1.Text = "发送";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// tb_send_data
			// 
			this.tb_send_data.Location = new System.Drawing.Point(293, 260);
			this.tb_send_data.Name = "tb_send_data";
			this.tb_send_data.Size = new System.Drawing.Size(100, 26);
			this.tb_send_data.TabIndex = 11;
			// 
			// btn_startServer
			// 
			this.btn_startServer.Location = new System.Drawing.Point(695, 24);
			this.btn_startServer.Name = "btn_startServer";
			this.btn_startServer.Size = new System.Drawing.Size(72, 35);
			this.btn_startServer.TabIndex = 9;
			this.btn_startServer.Text = "打开";
			this.btn_startServer.UseVisualStyleBackColor = true;
			this.btn_startServer.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_server_port
			// 
			this.tb_server_port.Location = new System.Drawing.Point(493, 33);
			this.tb_server_port.Name = "tb_server_port";
			this.tb_server_port.Size = new System.Drawing.Size(150, 26);
			this.tb_server_port.TabIndex = 8;
			this.tb_server_port.Text = "2000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(405, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "端口号";
			// 
			// tb_server_ip
			// 
			this.tb_server_ip.Location = new System.Drawing.Point(149, 33);
			this.tb_server_ip.Name = "tb_server_ip";
			this.tb_server_ip.Size = new System.Drawing.Size(150, 26);
			this.tb_server_ip.TabIndex = 6;
			this.tb_server_ip.Text = "192.168.2.241";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "本机-IP地址";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.mqtt_tip);
			this.tabPage3.Controls.Add(this.btn_mqtt_start);
			this.tabPage3.Controls.Add(this.btn_mqtt_stop);
			this.tabPage3.Controls.Add(this.tb_mqtt_port);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.cb_mqtt_ip);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1034, 668);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "MQTTServer";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// mqtt_tip
			// 
			this.mqtt_tip.AutoSize = true;
			this.mqtt_tip.Location = new System.Drawing.Point(37, 107);
			this.mqtt_tip.Name = "mqtt_tip";
			this.mqtt_tip.Size = new System.Drawing.Size(0, 20);
			this.mqtt_tip.TabIndex = 13;
			// 
			// btn_mqtt_start
			// 
			this.btn_mqtt_start.Location = new System.Drawing.Point(620, 36);
			this.btn_mqtt_start.Name = "btn_mqtt_start";
			this.btn_mqtt_start.Size = new System.Drawing.Size(75, 31);
			this.btn_mqtt_start.TabIndex = 12;
			this.btn_mqtt_start.Text = "Start";
			this.btn_mqtt_start.UseVisualStyleBackColor = true;
			this.btn_mqtt_start.Click += new System.EventHandler(this.btn_mqtt_start_Click);
			// 
			// btn_mqtt_stop
			// 
			this.btn_mqtt_stop.Location = new System.Drawing.Point(741, 36);
			this.btn_mqtt_stop.Name = "btn_mqtt_stop";
			this.btn_mqtt_stop.Size = new System.Drawing.Size(75, 31);
			this.btn_mqtt_stop.TabIndex = 11;
			this.btn_mqtt_stop.Text = "Stop";
			this.btn_mqtt_stop.UseVisualStyleBackColor = true;
			this.btn_mqtt_stop.Click += new System.EventHandler(this.btn_mqtt_stop_Click);
			// 
			// tb_mqtt_port
			// 
			this.tb_mqtt_port.Location = new System.Drawing.Point(449, 45);
			this.tb_mqtt_port.Name = "tb_mqtt_port";
			this.tb_mqtt_port.Size = new System.Drawing.Size(100, 26);
			this.tb_mqtt_port.TabIndex = 10;
			this.tb_mqtt_port.Text = "1883";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(332, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Server Port:";
			// 
			// cb_mqtt_ip
			// 
			this.cb_mqtt_ip.FormattingEnabled = true;
			this.cb_mqtt_ip.Location = new System.Drawing.Point(137, 39);
			this.cb_mqtt_ip.Name = "cb_mqtt_ip";
			this.cb_mqtt_ip.Size = new System.Drawing.Size(121, 28);
			this.cb_mqtt_ip.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Server IP:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btn_publish);
			this.tabPage4.Controls.Add(this.tb_mqtt_client_tip);
			this.tabPage4.Controls.Add(this.tb_account);
			this.tabPage4.Controls.Add(this.tb_password);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.tb_Client_Link_IP);
			this.tabPage4.Controls.Add(this.btn_matt_Connect);
			this.tabPage4.Controls.Add(this.btn_mqtt_disconnect);
			this.tabPage4.Controls.Add(this.tb_connect_port);
			this.tabPage4.Controls.Add(this.label7);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1034, 668);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "MQTTClient";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tb_mqtt_client_tip
			// 
			this.tb_mqtt_client_tip.Location = new System.Drawing.Point(63, 150);
			this.tb_mqtt_client_tip.Name = "tb_mqtt_client_tip";
			this.tb_mqtt_client_tip.Size = new System.Drawing.Size(100, 26);
			this.tb_mqtt_client_tip.TabIndex = 24;
			// 
			// tb_account
			// 
			this.tb_account.Location = new System.Drawing.Point(180, 92);
			this.tb_account.Name = "tb_account";
			this.tb_account.Size = new System.Drawing.Size(100, 26);
			this.tb_account.TabIndex = 23;
			this.tb_account.Text = "admin";
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(483, 92);
			this.tb_password.Name = "tb_password";
			this.tb_password.Size = new System.Drawing.Size(100, 26);
			this.tb_password.TabIndex = 22;
			this.tb_password.Text = "123456";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(366, 94);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 20);
			this.label9.TabIndex = 21;
			this.label9.Text = "Mqtt Passwd";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(59, 92);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 20);
			this.label10.TabIndex = 20;
			this.label10.Text = "Mqtt Account";
			// 
			// tb_Client_Link_IP
			// 
			this.tb_Client_Link_IP.Location = new System.Drawing.Point(180, 36);
			this.tb_Client_Link_IP.Name = "tb_Client_Link_IP";
			this.tb_Client_Link_IP.Size = new System.Drawing.Size(100, 26);
			this.tb_Client_Link_IP.TabIndex = 19;
			this.tb_Client_Link_IP.Text = "127.0.0.1";
			// 
			// btn_matt_Connect
			// 
			this.btn_matt_Connect.Location = new System.Drawing.Point(654, 27);
			this.btn_matt_Connect.Name = "btn_matt_Connect";
			this.btn_matt_Connect.Size = new System.Drawing.Size(75, 31);
			this.btn_matt_Connect.TabIndex = 18;
			this.btn_matt_Connect.Text = "Connect";
			this.btn_matt_Connect.UseVisualStyleBackColor = true;
			this.btn_matt_Connect.Click += new System.EventHandler(this.btn_matt_Connect_Click);
			// 
			// btn_mqtt_disconnect
			// 
			this.btn_mqtt_disconnect.Location = new System.Drawing.Point(775, 27);
			this.btn_mqtt_disconnect.Name = "btn_mqtt_disconnect";
			this.btn_mqtt_disconnect.Size = new System.Drawing.Size(96, 31);
			this.btn_mqtt_disconnect.TabIndex = 17;
			this.btn_mqtt_disconnect.Text = "Disconnect";
			this.btn_mqtt_disconnect.UseVisualStyleBackColor = true;
			this.btn_mqtt_disconnect.Click += new System.EventHandler(this.btn_mqtt_disconnect_Click);
			// 
			// tb_connect_port
			// 
			this.tb_connect_port.Location = new System.Drawing.Point(483, 36);
			this.tb_connect_port.Name = "tb_connect_port";
			this.tb_connect_port.Size = new System.Drawing.Size(100, 26);
			this.tb_connect_port.TabIndex = 16;
			this.tb_connect_port.Text = "1883";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(366, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Connect Port:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(71, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "Connect IP:";

			// 
			// textShow1
			// 
			this.textShow1.DataType = thinger.DataConvertLib.DataType.Float;
			this.textShow1.Location = new System.Drawing.Point(56, 98);
			this.textShow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textShow1.Name = "textShow1";
			this.textShow1.Offset = 4;
			this.textShow1.Size = new System.Drawing.Size(359, 43);
			this.textShow1.Start = 0;
			this.textShow1.TabIndex = 6;
			// 
			// textShow2
			// 
			this.textShow2.DataType = thinger.DataConvertLib.DataType.Float;
			this.textShow2.Location = new System.Drawing.Point(65, 88);
			this.textShow2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.textShow2.Name = "textShow2";
			this.textShow2.Offset = 4;
			this.textShow2.Size = new System.Drawing.Size(479, 73);
			this.textShow2.Start = 0;
			this.textShow2.TabIndex = 10;
			// 
			// btn_publish
			// 
			this.btn_publish.Location = new System.Drawing.Point(654, 81);
			this.btn_publish.Name = "btn_publish";
			this.btn_publish.Size = new System.Drawing.Size(75, 31);
			this.btn_publish.TabIndex = 25;
			this.btn_publish.Text = "publish";
			this.btn_publish.UseVisualStyleBackColor = true;
			this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 751);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMain";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_plc_port;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_plc_ip;
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private TextShow textShow1;
		private System.Windows.Forms.Button btn_startServer;
		private System.Windows.Forms.TextBox tb_server_port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_server_ip;
		private System.Windows.Forms.Label label4;
		private TextShow textShow2;
		private System.Windows.Forms.TextBox tb_send_data;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cb_mqtt_ip;
		private System.Windows.Forms.TextBox tb_mqtt_port;
		private System.Windows.Forms.Button btn_mqtt_start;
		private System.Windows.Forms.Button btn_mqtt_stop;
		private System.Windows.Forms.Label mqtt_tip;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox tb_Client_Link_IP;
		private System.Windows.Forms.Button btn_matt_Connect;
		private System.Windows.Forms.Button btn_mqtt_disconnect;
		private System.Windows.Forms.TextBox tb_connect_port;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_account;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tb_mqtt_client_tip;		
		private System.Windows.Forms.Button btn_publish;
	}
}