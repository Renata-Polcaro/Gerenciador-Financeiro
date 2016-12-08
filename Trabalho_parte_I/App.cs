using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class App : Application
	{
		public static INavigation Navigation;

		public App()
		{
			MainPage = new NavigationPage(new Trabalho_parte_I_View());
			App.Navigation = MainPage.Navigation;

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
