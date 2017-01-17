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
		Game game;
		/// <summary>
		/// Inicializuje novou instanci se vstupem user zakládá game
		/// </summary>
		/// <param name="user">User.</param>
		public Games(User user)
		{
			InitializeComponent();


			List<Game> game = CreateSampleData(user.name);
			SetListViewItems(game);

			//string dataToWrite = _jsonHelper.SerializeObject(user);
			//ReadAndWriteData(dataToWrite);

			this.user = user;

		}

		/// <summary>
		/// Generuje list s daty o hře
		/// </summary>
		/// <returns>The sample data.</returns>
		/// <param name="owner">Owner.</param>
		private List<Game> CreateSampleData(string owner)
		{
			List<Game> story = new List<Game>();

			int[,] storryID = { { 1, 2 },
								{ 3, 4 },
								{ 1, 3 }
							  };

			story.Add(new Game() { Owner = owner, Name = "Derpice", Time = 4, CreateTime = new DateTime() });
			story.Add(new Game() { Owner = owner, Name = "Startov", Time = 8, CreateTime = new DateTime() });
			return story;
		}

		//private void ReadAndWriteData(string dataToWrite)
		//{
		//	List<User> user = Task.Run(() => ReadAndWriteAsync(dataToWrite)).Result;
		//	SetListViewItems(user);
		//}

		/// <summary>
		/// Výpíše informace o hře do ListView
		/// </summary>
		/// <param name="story">Story.</param>
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

		/// <summary>
		/// Odkaz tlačítka na hlavní stranku
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void StoriesSelect(object sender, ItemTappedEventArgs args)
		{
			Game game = args.Item as Game;
			this.Navigation.PushModalAsync(new MainStory(user, game));
		}

		/// <summary>
		/// Přidání nové hry
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void add(object sender, EventArgs args)
		{
			//this.Navigation.PushModalAsync(new vyberHrace());
		}

	}
}
