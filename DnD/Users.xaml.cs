using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace DnD
{
	public partial class Users : ContentPage
	{
		//readonly JsonFile _jsonFileProvider = new JsonFile();
		//readonly JsonHelper _jsonHelper = new JsonHelper();

		/// <summary>
		/// Inicalizuje třídu vytváří "user"
		/// </summary>
		public Users()
		{
			//InitializeComponent();

			//var dbConnection = App.Database;


			//UsersDatabase usersDatabase = App.Database;
			//User user = new User() { name = "Derpos", attack = 3, defense = 85, life = 6, money = 50, lost = 6, win = 12, ID = 1 };
			//App.Database.SaveItemAsync(user);
			//SetListViewItems(App.Database.GetItemsAsync().Result);
			InitializeComponent();
			var dbConnection = App.Database;

			UsersDatabase userDatabase = App.Database;
			User item = new User();
			item.name = "item";
			item.money = 42;
			App.Database.SaveItemAsync(item);

		}

		/// <summary>
		/// Vypisuje list hráču do ListView
		/// </summary>
		/// <param name="persons">Persons.</param>
		private void SetListViewItems(List<User> persons)
		{
			PlayersList.ItemsSource = persons;
		}


		//private async Task<List<User>> ReadAndWriteAsync(string dataToWrite)
		//{
		//	await _jsonFileProvider.WriteDataAsync(dataToWrite);
		//	string dataFromFile = await _jsonFileProvider.ReadDataAsync();

		//	return _jsonHelper.DeserializeObject(dataFromFile);
		//}

		/// <summary>
		/// Odkaz na víber hry s vybraným hráčem
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void PlayerSelect(object sender, ItemTappedEventArgs args)
		{
			var user = args.Item as User;
			await Navigation.PushModalAsync(new MainStory(user));
		}


		/// <summary>
		/// Noví hráč/postava
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void add(object sender, EventArgs args)
		{
			this.Navigation.PushAsync(new Welcome());
		}

	}
}
