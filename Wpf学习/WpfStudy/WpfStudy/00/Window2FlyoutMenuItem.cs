using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy._00
{
	public class Window2FlyoutMenuItem
	{
		public Window2FlyoutMenuItem()
		{
			TargetType = typeof(Window2FlyoutMenuItem);
		}
		public int Id { get; set; }
		public string Title { get; set; }

		public Type TargetType { get; set; }
	}
}