using System.Collections.Generic;
using Xamarin.Forms;

namespace DnD
{
	public partial class App : Application
	{
		public static User player;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Welcome());
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
		private static UsersDatabase _database;

		public static UsersDatabase Database
		{
			get
			{
				if (_database == null)
				{
					_database = new UsersDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("User.db3"));
				}
				return _database;
			}
		}
	}
}
