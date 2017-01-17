using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainStory : ContentPage
	{
		User user;
		Game game;

		/// <summary>
		/// Inicializuje novou instanci se vstupem "user" a "game"
		/// </summary>
		/// <param name="user">User.</param>
		/// <param name="game">Game.</param>
		public MainStory(User user, Game game)
		{
			InitializeComponent();

			this.user = user;
			this.game = game;

			player.Text = user.name;
		}

		/// <summary>
		/// Odkaz na stranku MainExpedition
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void expedition(object sender, EventArgs args)
		{
			
			await Navigation.PushAsync(new MainExpedition(user));
		}

		/// <summary>
		/// Odkaz na stranku MainArena
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void arena(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainArena(user));
		}

		/// <summary>
		/// Odkaz na stranku Games
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void games(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Games(user));
		}

		/// <summary>
		/// Odkaz na stranku MainShop
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void shop(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new MainShop(user));
		}


	}
}
