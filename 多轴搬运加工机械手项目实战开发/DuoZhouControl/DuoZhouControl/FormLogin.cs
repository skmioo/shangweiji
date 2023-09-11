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
			//MySqlDataReader

		}

        #endregion
    }
}
