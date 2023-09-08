
namespace LoginPage
{
	partial class Form_Login
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
			this.txt_Account = new System.Windows.Forms.TextBox();
			this.txt_passwd = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.lb_title = new System.Windows.Forms.Label();
			this.pic_close = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(73, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "登录用户:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(73, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "登录密码:";
			// 
			// txt_Account
			// 
			this.txt_Account.Location = new System.Drawing.Point(194, 90);
			this.txt_Account.Name = "txt_Account";
			this.txt_Account.Size = new System.Drawing.Size(129, 26);
			this.txt_Account.TabIndex = 2;
			this.txt_Account.Text = "111";
			this.txt_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Account_KeyDown);
			// 
			// txt_passwd
			// 
			this.txt_passwd.Location = new System.Drawing.Point(194, 140);
			this.txt_passwd.Name = "txt_passwd";
			this.txt_passwd.PasswordChar = '*';
			this.txt_passwd.Size = new System.Drawing.Size(129, 26);
			this.txt_passwd.TabIndex = 3;
			this.txt_passwd.Text = "111";
			this.txt_passwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Account_KeyDown);
			// 
			// btn_login
			// 
			this.btn_login.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
			this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
			this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
			this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_login.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_login.ForeColor = System.Drawing.Color.White;
			this.btn_login.Location = new System.Drawing.Point(118, 197);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(205, 44);
			this.btn_login.TabIndex = 4;
			this.btn_login.Text = "登录系统";
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// lb_title
			// 
			this.lb_title.BackColor = System.Drawing.Color.Transparent;
			this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_title.ForeColor = System.Drawing.Color.White;
			this.lb_title.Location = new System.Drawing.Point(0, 0);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(497, 58);
			this.lb_title.TabIndex = 1;
			this.lb_title.Text = "登录系统";
			this.lb_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_title_MouseDown);
			this.lb_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_title_MouseMove);
			// 
			// pic_close
			// 
			this.pic_close.BackColor = System.Drawing.Color.Transparent;
			this.pic_close.Image = global::PlcTcp.Properties.Resources.close;
			this.pic_close.Location = new System.Drawing.Point(430, 12);
			this.pic_close.Name = "pic_close";
			this.pic_close.Size = new System.Drawing.Size(36, 34);
			this.pic_close.TabIndex = 6;
			this.pic_close.TabStop = false;
			this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
			// 
			// Form_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(497, 280);
			this.Controls.Add(this.pic_close);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.txt_passwd);
			this.Controls.Add(this.txt_Account);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_title_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_title_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Account;
		private System.Windows.Forms.TextBox txt_passwd;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Label lb_title;
		private System.Windows.Forms.PictureBox pic_close;
	}
}

