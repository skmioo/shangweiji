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
	public partial class FormMain : Form
	{
		public const string FormName_集中监控 = "集中监控";
		public const string FormName_系统设置 = "系统设置";

		public FormMain()
		{
			InitializeComponent();
			this.Load += FormMain_Load;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			FormNav formNav = new FormNav();
			formNav.Show(DockMain);
			formNav.DockPanel.DockLeftPortion = 110.0f;
			//影藏时的比例
			formNav.AutoHidePortion = 110.0f/1280.0f;
			formNav.OpenForm = OpenForm;
		}

		public void OpenForm(string formName)
		{
			DockContent frm = FindDockContent(formName);
			if (frm != null)
			{
				frm.BringToFront();
				frm.Activate();
				return;
			}
			switch (formName)
			{
				case FormName_集中监控:
					new FormMonitor().Show(DockMain);
					break;
				case FormName_系统设置:
					new FormSysSet().Show(DockMain);
					break;
				default:
					break;
			}
		}

		private DockContent FindDockContent(string formName)
		{
			foreach (DockContent item in DockMain.Documents)
			{
				if (item.Text == formName)
				{
					return item;
				}
			}
			return null;
		}
	}
}
