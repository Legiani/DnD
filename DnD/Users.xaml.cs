using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class Users : ContentPage
	{
		//readonly JsonFile _jsonFileProvider = new JsonFile();
		//readonly JsonHelper _jsonHelper = new JsonHelper();

		public Users()
		{
			InitializeComponent();

			List<User> user = CreateSampleData();
			SetListViewItems(user);

			//string dataToWrite = _jsonHelper.SerializeObject(user);
			//ReadAndWriteData(dataToWrite);
		}

		private List<User> CreateSampleData()
		{
			List<User> persons = new List<User>();
			persons.Add(new User() { name = "Bára", attack = 3, defense = 85, life = 6, money = 50, lost = 6, win = 12 });
			persons.Add(new User() { name = "Kuba", attack = 30, defense = 55, life = 4, money = 130, lost = 2, win = 22 });
			return persons;
		}

		//private void ReadAndWriteData(string dataToWrite)
		//{
		//	List<User> user = Task.Run(() => ReadAndWriteAsync(dataToWrite)).Result;
		//	SetListViewItems(user);
		//}

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

		public async void PlayerSelect(object sender, ItemTappedEventArgs args)
		{
			var user = args.Item as User;
			await Navigation.PushModalAsync(new Games(user));
		}



		public void add(object sender, EventArgs args)
		{
			this.Navigation.PushAsync(new Welcome());
		}

	}
}
