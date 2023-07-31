
namespace SocketTcp
{
	partial class FormTcpClient
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
			this.btn_selectfile = new System.Windows.Forms.Button();
			this.txt_file = new System.Windows.Forms.TextBox();
			this.txt_send = new System.Windows.Forms.TextBox();
			this.txt_Tip = new System.Windows.Forms.TextBox();
			this.txt_port = new System.Windows.Forms.TextBox();
			this.txt_ip = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_LinkServer = new System.Windows.Forms.Button();
			this.txt_client_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_send_msg = new System.Windows.Forms.Button();
			this.btn_send_file = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_selectfile
			// 
			this.btn_selectfile.Location = new System.Drawing.Point(296, 523);
			this.btn_selectfile.Name = "btn_selectfile";
			this.btn_selectfile.Size = new System.Drawing.Size(100, 23);
			this.btn_selectfile.TabIndex = 12;
			this.btn_selectfile.Text = "选择文件";
			this.btn_selectfile.UseVisualStyleBackColor = true;
			this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
			// 
			// txt_file
			// 
			this.txt_file.Location = new System.Drawing.Point(46, 524);
			this.txt_file.Name = "txt_file";
			this.txt_file.Size = new System.Drawing.Size(217, 21);
			this.txt_file.TabIndex = 11;
			// 
			// txt_send
			// 
			this.txt_send.Location = new System.Drawing.Point(46, 272);
			this.txt_send.Multiline = true;
			this.txt_send.Name = "txt_send";
			this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_send.Size = new System.Drawing.Size(330, 229);
			this.txt_send.TabIndex = 10;
			// 
			// txt_Tip
			// 
			this.txt_Tip.Location = new System.Drawing.Point(46, 25);
			this.txt_Tip.Multiline = true;
			this.txt_Tip.Name = "txt_Tip";
			this.txt_Tip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_Tip.Size = new System.Drawing.Size(330, 229);
			this.txt_Tip.TabIndex = 9;
			// 
			// txt_port
			// 
			this.txt_port.Location = new System.Drawing.Point(556, 107);
			this.txt_port.Name = "txt_port";
			this.txt_port.Size = new System.Drawing.Size(118, 21);
			this.txt_port.TabIndex = 16;
			this.txt_port.Text = "1234";
			// 
			// txt_ip
			// 
			this.txt_ip.Location = new System.Drawing.Point(556, 64);
			this.txt_ip.Name = "txt_ip";
			this.txt_ip.Size = new System.Drawing.Size(118, 21);
			this.txt_ip.TabIndex = 15;
			this.txt_ip.Text = "192.168.40.61";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(430, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 14;
			this.label2.Text = "端口号：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(430, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 19);
			this.label1.TabIndex = 13;
			this.label1.Text = "服务器的Ip地址：";
			// 
			// btn_LinkServer
			// 
			this.btn_LinkServer.Location = new System.Drawing.Point(480, 231);
			this.btn_LinkServer.Name = "btn_LinkServer";
			this.btn_LinkServer.Size = new System.Drawing.Size(127, 51);
			this.btn_LinkServer.TabIndex = 17;
			this.btn_LinkServer.Text = "连接服务器";
			this.btn_LinkServer.UseVisualStyleBackColor = true;
			this.btn_LinkServer.Click += new System.EventHandler(this.btn_LinkServer_Click);
			// 
			// txt_client_name
			// 
			this.txt_client_name.Location = new System.Drawing.Point(556, 156);
			this.txt_client_name.Name = "txt_client_name";
			this.txt_client_name.Size = new System.Drawing.Size(118, 21);
			this.txt_client_name.TabIndex = 19;
			this.txt_client_name.Text = "客户端1号";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(430, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 18;
			this.label3.Text = "本机名称";
			// 
			// btn_send_msg
			// 
			this.btn_send_msg.Location = new System.Drawing.Point(480, 334);
			this.btn_send_msg.Name = "btn_send_msg";
			this.btn_send_msg.Size = new System.Drawing.Size(127, 51);
			this.btn_send_msg.TabIndex = 20;
			this.btn_send_msg.Text = "发送消息";
			this.btn_send_msg.UseVisualStyleBackColor = true;
			this.btn_send_msg.Click += new System.EventHandler(this.btn_send_msg_Click);
			// 
			// btn_send_file
			// 
			this.btn_send_file.Location = new System.Drawing.Point(480, 440);
			this.btn_send_file.Name = "btn_send_file";
			this.btn_send_file.Size = new System.Drawing.Size(127, 51);
			this.btn_send_file.TabIndex = 21;
			this.btn_send_file.Text = "发送文件";
			this.btn_send_file.UseVisualStyleBackColor = true;
			this.btn_send_file.Click += new System.EventHandler(this.btn_send_file_Click);
			// 
			// FormTcpClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 589);
			this.Controls.Add(this.btn_send_file);
			this.Controls.Add(this.btn_send_msg);
			this.Controls.Add(this.txt_client_name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_LinkServer);
			this.Controls.Add(this.txt_port);
			this.Controls.Add(this.txt_ip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_selectfile);
			this.Controls.Add(this.txt_file);
			this.Controls.Add(this.txt_send);
			this.Controls.Add(this.txt_Tip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormTcpClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "基于Socket开发的TCP通信客户端";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_selectfile;
		private System.Windows.Forms.TextBox txt_file;
		private System.Windows.Forms.TextBox txt_send;
		private System.Windows.Forms.TextBox txt_Tip;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.TextBox txt_ip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_LinkServer;
		private System.Windows.Forms.TextBox txt_client_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_send_msg;
		private System.Windows.Forms.Button btn_send_file;
	}
}