
namespace SocketTcp
{
	partial class FormTcpServer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_ip = new System.Windows.Forms.TextBox();
			this.txt_port = new System.Windows.Forms.TextBox();
			this.txt_Tip = new System.Windows.Forms.TextBox();
			this.txt_send = new System.Windows.Forms.TextBox();
			this.lbOnline = new System.Windows.Forms.ListBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btn_selectfile = new System.Windows.Forms.Button();
			this.btn_startserver = new System.Windows.Forms.Button();
			this.btn_send_msg_all = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btn_sendmsg = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(438, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "本机的Ip地址：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(438, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "端口号：";
			// 
			// txt_ip
			// 
			this.txt_ip.Location = new System.Drawing.Point(564, 77);
			this.txt_ip.Name = "txt_ip";
			this.txt_ip.Size = new System.Drawing.Size(118, 23);
			this.txt_ip.TabIndex = 2;
			this.txt_ip.Text = "192.168.40.55";
			// 
			// txt_port
			// 
			this.txt_port.Location = new System.Drawing.Point(564, 120);
			this.txt_port.Name = "txt_port";
			this.txt_port.Size = new System.Drawing.Size(118, 23);
			this.txt_port.TabIndex = 3;
			this.txt_port.Text = "1234";
			// 
			// txt_Tip
			// 
			this.txt_Tip.Location = new System.Drawing.Point(31, 43);
			this.txt_Tip.Multiline = true;
			this.txt_Tip.Name = "txt_Tip";
			this.txt_Tip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_Tip.Size = new System.Drawing.Size(330, 229);
			this.txt_Tip.TabIndex = 4;
			// 
			// txt_send
			// 
			this.txt_send.Location = new System.Drawing.Point(31, 290);
			this.txt_send.Multiline = true;
			this.txt_send.Name = "txt_send";
			this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_send.Size = new System.Drawing.Size(330, 229);
			this.txt_send.TabIndex = 5;
			// 
			// lbOnline
			// 
			this.lbOnline.FormattingEnabled = true;
			this.lbOnline.ItemHeight = 17;
			this.lbOnline.Location = new System.Drawing.Point(442, 200);
			this.lbOnline.Name = "lbOnline";
			this.lbOnline.Size = new System.Drawing.Size(240, 72);
			this.lbOnline.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(31, 542);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(217, 23);
			this.textBox3.TabIndex = 7;
			// 
			// btn_selectfile
			// 
			this.btn_selectfile.Location = new System.Drawing.Point(281, 541);
			this.btn_selectfile.Name = "btn_selectfile";
			this.btn_selectfile.Size = new System.Drawing.Size(100, 23);
			this.btn_selectfile.TabIndex = 8;
			this.btn_selectfile.Text = "选择文件";
			this.btn_selectfile.UseVisualStyleBackColor = true;
			// 
			// btn_startserver
			// 
			this.btn_startserver.Location = new System.Drawing.Point(522, 307);
			this.btn_startserver.Name = "btn_startserver";
			this.btn_startserver.Size = new System.Drawing.Size(100, 23);
			this.btn_startserver.TabIndex = 9;
			this.btn_startserver.Text = "启动服务";
			this.btn_startserver.UseVisualStyleBackColor = true;
			this.btn_startserver.Click += new System.EventHandler(this.btn_startserver_Click);
			// 
			// btn_send_msg_all
			// 
			this.btn_send_msg_all.Location = new System.Drawing.Point(522, 394);
			this.btn_send_msg_all.Name = "btn_send_msg_all";
			this.btn_send_msg_all.Size = new System.Drawing.Size(100, 23);
			this.btn_send_msg_all.TabIndex = 11;
			this.btn_send_msg_all.Text = "群发消息";
			this.btn_send_msg_all.UseVisualStyleBackColor = true;
			this.btn_send_msg_all.Click += new System.EventHandler(this.btn_send_msg_all_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(522, 441);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "选择文件";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btn_sendmsg
			// 
			this.btn_sendmsg.Location = new System.Drawing.Point(522, 350);
			this.btn_sendmsg.Name = "btn_sendmsg";
			this.btn_sendmsg.Size = new System.Drawing.Size(100, 23);
			this.btn_sendmsg.TabIndex = 13;
			this.btn_sendmsg.Text = "发送消息";
			this.btn_sendmsg.Click += new System.EventHandler(this.btn_sendmsg_Click);
			// 
			// FormTcpServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 589);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btn_send_msg_all);
			this.Controls.Add(this.btn_sendmsg);
			this.Controls.Add(this.btn_startserver);
			this.Controls.Add(this.btn_selectfile);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.lbOnline);
			this.Controls.Add(this.txt_send);
			this.Controls.Add(this.txt_Tip);
			this.Controls.Add(this.txt_port);
			this.Controls.Add(this.txt_ip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormTcpServer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "基于Socket开发的TCP通信";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ip;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.TextBox txt_Tip;
		private System.Windows.Forms.TextBox txt_send;
		private System.Windows.Forms.ListBox lbOnline;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btn_selectfile;
		private System.Windows.Forms.Button btn_startserver;
		private System.Windows.Forms.Button btn_send_msg_all;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btn_sendmsg;
	}
}

