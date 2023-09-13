using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DuoZhouControl
{
	public delegate void OpenFormDelegate(string formName);
	public partial class FormNav : DockContent
	{

		
		public FormNav()
		{
			InitializeComponent();
		}

		public OpenFormDelegate OpenForm;

		private void btn_集中监控_Click(object sender, EventArgs e)
		{
			OpenForm?.Invoke(FormMain.FormName_集中监控);
		}

		private void btn_系统设置_Click(object sender, EventArgs e)
		{
			OpenForm?.Invoke(FormMain.FormName_系统设置);
		}
	}
}
