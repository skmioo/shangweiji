using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;


namespace WpfStudy._00
{
	class Window2 : Window
	{
		public Window2(string xmalFile)
		{
			//设置窗体大小
			this.Width = 285;
			this.Height = 250;
			this.Left = this.Top = 100;
			this.Title = "动态加载 Xmal";
			DependencyObject rootElement = null;
			using (FileStream fs = new FileStream(xmalFile, FileMode.Open))
			{
				rootElement = (DependencyObject)XamlReader.Load(fs);
			}
			this.Content = rootElement;
			Button button = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "Button");
			button.Click += OnClick;
		}

		private void OnClick(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("点击!");
		}
	}
}
