using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfStudy
{
	class Window1 : Window
	{
		private Button button1;
		public Window1()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			//设置窗体大小
			this.Width = 285;
			this.Height = 250;
			this.Left = this.Top = 100;
			this.Title = "Code-Only Window";

			//创建面板
			DockPanel panel = new DockPanel();
			//创建按钮对象
			button1 = new Button();
			button1.Content = "Click Me";
			button1.Margin = new Thickness(30);
			button1.Click += OnClick;

			//IAddChild container = panel;
			//container.AddChild(button1);
			((IAddChild)panel).AddChild(button1);
			((IAddChild)this).AddChild(panel);
		}

		private void OnClick(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("点击!");
		}
	}
}
