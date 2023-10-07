
namespace ModbusPjt
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
			this.btn_connect = new System.Windows.Forms.Button();
			this.btn_disconnect = new System.Windows.Forms.Button();
			this.tb_slaveId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.tb_startaddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_readLength = new System.Windows.Forms.TextBox();
			this.btn_read_outputstatus = new System.Windows.Forms.Button();
			this.rtb_msg = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(280, 129);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(75, 43);
			this.btn_connect.TabIndex = 0;
			this.btn_connect.Text = "连接";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// btn_disconnect
			// 
			this.btn_disconnect.Location = new System.Drawing.Point(423, 129);
			this.btn_disconnect.Name = "btn_disconnect";
			this.btn_disconnect.Size = new System.Drawing.Size(75, 43);
			this.btn_disconnect.TabIndex = 1;
			this.btn_disconnect.Text = "关闭";
			this.btn_disconnect.UseVisualStyleBackColor = true;
			this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
			// 
			// tb_slaveId
			// 
			this.tb_slaveId.Location = new System.Drawing.Point(280, 216);
			this.tb_slaveId.Name = "tb_slaveId";
			this.tb_slaveId.Size = new System.Drawing.Size(122, 21);
			this.tb_slaveId.TabIndex = 2;
			this.tb_slaveId.Text = "1";
			this.tb_slaveId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(187, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "从站地址:";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(187, 246);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(59, 12);
			this.label.TabIndex = 5;
			this.label.Text = "开始地址:";
			// 
			// tb_startaddress
			// 
			this.tb_startaddress.Location = new System.Drawing.Point(280, 243);
			this.tb_startaddress.Name = "tb_startaddress";
			this.tb_startaddress.Size = new System.Drawing.Size(122, 21);
			this.tb_startaddress.TabIndex = 4;
			this.tb_startaddress.Text = "0";
			this.tb_startaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(187, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "读取长度:";
			// 
			// tb_readLength
			// 
			this.tb_readLength.Location = new System.Drawing.Point(280, 270);
			this.tb_readLength.Name = "tb_readLength";
			this.tb_readLength.Size = new System.Drawing.Size(122, 21);
			this.tb_readLength.TabIndex = 6;
			this.tb_readLength.Text = "10";
			this.tb_readLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_read_outputstatus
			// 
			this.btn_read_outputstatus.Location = new System.Drawing.Point(423, 209);
			this.btn_read_outputstatus.Name = "btn_read_outputstatus";
			this.btn_read_outputstatus.Size = new System.Drawing.Size(75, 33);
			this.btn_read_outputstatus.TabIndex = 8;
			this.btn_read_outputstatus.Text = "读取";
			this.btn_read_outputstatus.UseVisualStyleBackColor = true;
			this.btn_read_outputstatus.Click += new System.EventHandler(this.btn_read_outputstatus_Click);
			// 
			// rtb_msg
			// 
			this.rtb_msg.Location = new System.Drawing.Point(189, 327);
			this.rtb_msg.Name = "rtb_msg";
			this.rtb_msg.Size = new System.Drawing.Size(386, 94);
			this.rtb_msg.TabIndex = 9;
			this.rtb_msg.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtb_msg);
			this.Controls.Add(this.btn_read_outputstatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_readLength);
			this.Controls.Add(this.label);
			this.Controls.Add(this.tb_startaddress);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_slaveId);
			this.Controls.Add(this.btn_disconnect);
			this.Controls.Add(this.btn_connect);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Button btn_disconnect;
		private System.Windows.Forms.TextBox tb_slaveId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox tb_startaddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_readLength;
		private System.Windows.Forms.Button btn_read_outputstatus;
		private System.Windows.Forms.RichTextBox rtb_msg;
	}
}

