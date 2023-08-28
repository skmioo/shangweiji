using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
	public partial class Form_Login : Form
	{
		public Form_Login()
		{
			InitializeComponent();
			//10毫秒一次
			closeTimer.Interval = 10;
			closeTimer.Tick += CloseTimer_Tick;
		}

		#region 窗体渐变色效果

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			Rectangle rect = new Rectangle(new Point(0,0), new Size(Width, Height));
			LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(226, 101, 127), Color.FromArgb(93, 127, 124), LinearGradientMode.BackwardDiagonal);
			g.FillRectangle(brush, rect);
		}

		#endregion


		#region 无边框拖动
		private Point mPoint;
		private void lb_title_MouseDown(object sender, MouseEventArgs e)
		{
			mPoint = e.Location;
		}

		private void lb_title_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);				
			}
		}

		#endregion
		private Timer closeTimer = new Timer();
		/// <summary>
		/// 关闭应用
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pic_close_Click(object sender, EventArgs e)
		{
			closeTimer.Enabled = true;
		}

		private void CloseTimer_Tick(object sender, EventArgs e)
		{
			if (this.Opacity >= 0.025)
			{
				this.Opacity -= 0.025;
			}
			else
			{
				closeTimer.Enabled = false;
				Close();
			}
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			MessageBox.Show("登录成功");
		}

		private void txt_Account_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn_login_Click(null, null);
			}
		}
	}
}
