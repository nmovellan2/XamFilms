using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamFilm
{
	public partial class App : Application
	{
		public App ()
		{
            LiveReload.Init();//Para poder utilizar Live Reload
			InitializeComponent();

			MainPage = new Views.AcknowledgeView();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
