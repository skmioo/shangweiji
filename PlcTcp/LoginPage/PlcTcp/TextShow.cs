using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;

namespace PlcTcp
{
	public partial class TextShow : UserControl
	{

		public TextShow()
		{
			InitializeComponent();
		}
		
		public int Start { get; set; }
		public int Offset { get; set;}
		public DataType DataType { get; set; }

		private string varValue;
		internal string VarValue {
			get {
				return varValue;
			}
			set {
				varValue = value;
				this.textBox1.Text = varValue;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
