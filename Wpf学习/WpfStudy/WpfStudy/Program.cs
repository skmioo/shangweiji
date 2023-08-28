using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfStudy._00;

namespace WpfStudy
{
	class Program : Application
	{
		/// <summary>
		/// 需要在项目属性里设置启动对象
		/// </summary>
		[STAThread]
		static void Main()
		{
			//CreatePageByScript();
			//CreatePageByReadXaml();
			CreateWindow3();
		}

		/// <summary>
		/// 脚本创建页面
		/// </summary>
		static void CreatePageByScript()
		{
			Program app = new Program();
			app.MainWindow = new Window1();
			app.MainWindow.ShowDialog();
		}

		/// <summary>
		/// 读取Xaml来创建窗口 （xmal文件有些问题，先不管了）
		/// </summary>
		static void CreatePageByReadXaml()
		{
			Program app = new Program();
			app.MainWindow = new Window2("E:/shangweiji/Wpf学习/WpfStudy/WpfStudy/TestWindow.xaml");
			app.MainWindow.ShowDialog();
		}

		/// <summary>
		/// 自适应页面
		/// </summary>
		static void CreateWindow3()
		{
			Program app = new Program();
			app.MainWindow = new Window7();
			app.MainWindow.ShowDialog();
		}
	}
}
