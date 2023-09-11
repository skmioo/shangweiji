
namespace DuoZhouControl
{
	partial class FormLogin
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
			this.cmb_User = new System.Windows.Forms.ComboBox();
			this.txt_LoginPwd = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(115, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "登录用户:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(115, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "登录密码：";
			// 
			// cmb_User
			// 
			this.cmb_User.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cmb_User.FormattingEnabled = true;
			this.cmb_User.Location = new System.Drawing.Point(226, 47);
			this.cmb_User.Name = "cmb_User";
			this.cmb_User.Size = new System.Drawing.Size(158, 27);
			this.cmb_User.TabIndex = 2;
			// 
			// txt_LoginPwd
			// 
			this.txt_LoginPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_LoginPwd.Location = new System.Drawing.Point(226, 105);
			this.txt_LoginPwd.Name = "txt_LoginPwd";
			this.txt_LoginPwd.PasswordChar = '*';
			this.txt_LoginPwd.Size = new System.Drawing.Size(158, 26);
			this.txt_LoginPwd.TabIndex = 3;
			this.txt_LoginPwd.Text = "123";
			// 
			// btn_Login
			// 
			this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Login.Location = new System.Drawing.Point(138, 161);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(75, 36);
			this.btn_Login.TabIndex = 4;
			this.btn_Login.Text = "登录";
			this.btn_Login.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Exit.Location = new System.Drawing.Point(280, 161);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 36);
			this.btn_Exit.TabIndex = 5;
			this.btn_Exit.Text = "退出";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 237);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_LoginPwd);
			this.Controls.Add(this.cmb_User);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "系统登录";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmb_User;
		private System.Windows.Forms.TextBox txt_LoginPwd;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Exit;
	}
}

