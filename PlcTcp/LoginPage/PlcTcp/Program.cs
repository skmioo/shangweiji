using PlcTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form_Login frm = new Form_Login();
			DialogResult dr = frm.ShowDialog();
			if (dr == DialogResult.OK)
			{
				Application.Run(new FrmMain());
			}	
		}
	}
}
