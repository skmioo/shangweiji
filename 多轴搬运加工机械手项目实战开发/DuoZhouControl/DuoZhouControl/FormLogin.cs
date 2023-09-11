using DuoZhouControl.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoZhouControl
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			InitialUserList();
		}

        #region 初始化用户列表

        private void InitialUserList()
        {
			string sql = "select * from sysadmins";
			MySqlDataReader dr = MySQLHelper.GetReader(sql);
			List<string> userList = new List<string>();
			while (dr.Read())
			{
				userList.Add(dr["LoginName"].ToString());
			}
			if (userList.Count > 0)
			{
				this.cmb_User.DataSource = userList;
				this.cmb_User.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("用户列表为空！", "系统登录");
			}
		}

        #endregion
    }
}
