using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainShop : ContentPage
	{
		User user;

		public MainShop(User user)
		{
			InitializeComponent();
			this.user = user;
		}
		public async void expedition(object sender, EventArgs args)
		{
			Game game = new Game();
			await Navigation.PushAsync(new MainStory(user, game));
		}
	}
}
