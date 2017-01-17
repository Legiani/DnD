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

		public void expedition(object sender, EventArgs args)
		{
			
			Navigation.PushAsync(new Games(user));
		}

		public void arena(object sender, EventArgs args)
		{
			Navigation.PushAsync(new MainArena(user));
		}

		public void games(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Games(user));
		}

		public void shop(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Games(user));
		}
	}
}
