using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainStory : ContentPage
	{
		User user;
		Game game;


		public MainStory(User user, Game game)
		{
			InitializeComponent();

			this.user = user;
			this.game = game;

			player.Text = user.name;
		}


		public async void expedition(object sender, EventArgs args)
		{
			
			await Navigation.PushAsync(new MainExpedition(user));
		}

		public async void arena(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainArena(user));
		}

		public async void games(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Games(user));
		}

		public async void shop(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new MainShop(user));
		}


	}
}
