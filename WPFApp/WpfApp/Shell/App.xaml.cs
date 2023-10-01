using Prism.Ioc;
using Prism.Unity;
using Shell.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Shell
{
	/// <summary>
	/// App.xaml 的交互逻辑
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override Window CreateShell()
		{
			return new MainWindow();
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}
	}
}
