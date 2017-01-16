using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
public partial class Games : ContentPage
	{
		//readonly JsonFile _jsonFileProvider = new JsonFile();
		//readonly JsonHelper _jsonHelper = new JsonHelper();

		User user;

		public Games(User user)
		{
			InitializeComponent();

			List<Game> game = CreateSampleData();
			SetListViewItems(game);

			//string dataToWrite = _jsonHelper.SerializeObject(user);
			//ReadAndWriteData(dataToWrite);

			this.user = user;
		}

		private List<Game> CreateSampleData()
		{
			List<Game> story = new List<Game>();

			int[,] storryID = { { 1, 2 },
								{ 3, 4 },
								{ 1, 3 }
							  };

			story.Add(new Game() { Owner = this.user.name, Name = "Derpice", Story = storryID, CreateTime = new DateTime() });
			story.Add(new Game() { Owner = user.name, Name = "Startov", Story = storryID, CreateTime = new DateTime() });
			return story;
		}

		//private void ReadAndWriteData(string dataToWrite)
		//{
		//	List<User> user = Task.Run(() => ReadAndWriteAsync(dataToWrite)).Result;
		//	SetListViewItems(user);
		//}

		private void SetListViewItems(List<Game> story)
		{
			StoriesList.ItemsSource = story;
		}


		//private async Task<List<User>> ReadAndWriteAsync(string dataToWrite)
		//{
		//	await _jsonFileProvider.WriteDataAsync(dataToWrite);
		//	string dataFromFile = await _jsonFileProvider.ReadDataAsync();

		//	return _jsonHelper.DeserializeObject(dataFromFile);
		//}

		public void StoriesSelect(object sender, ItemTappedEventArgs args)
		{
			var user = args.Item as User;
			this.Navigation.PushModalAsync(new Games(user));
		}

		public void add(object sender, EventArgs args)
		{
			//this.Navigation.PushModalAsync(new vyberHrace());
		}

	}
}
