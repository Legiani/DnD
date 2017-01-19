using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainShop : ContentPage
	{
		User user;
		/// <summary>
		///  Inicializuje novou instanci se vstupem "user"
		/// </summary>
		/// <param name="user">User.</param>
		public MainShop(User user)
		{
			InitializeComponent();
			this.user = user;
		}

		/// <summary>
		/// Návrat do menu
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void menu(object sender, EventArgs args)
		{
			Game game = new Game();
			await Navigation.PushModalAsync(new MainStory(user, game));
		}
	}
}
