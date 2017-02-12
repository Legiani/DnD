using System;
using System.Collections.Generic;
using System.Diagnostics;
using SQLitePCL;
using Xamarin.Forms;

namespace DnD
{
	public partial class Users : ContentPage
	{
		/// <summary>
		/// Inicalizuje třídu vytváří "user"
		/// </summary>
		public Users()
		{
			InitializeComponent();
			var dbConnection = App.Database;

			UsersDatabase usersDatabase = App.Database;
			SetListViewItems(App.Database.GetItemsAsync().Result);
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
			App.player = args.Item as User;
			await Navigation.PushModalAsync(new MainStory());
		}


		/// <summary>
		/// Noví hráč/postava
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void add(object sender, EventArgs args)
		{
			this.Navigation.PushModalAsync(new NewUser());
		}

	}
}
