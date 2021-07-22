using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			this.MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
