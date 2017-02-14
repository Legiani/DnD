using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainCity : ContentPage
	{
		public MainCity()
		{
			InitializeComponent();

			player.Text = App.player.name;

		}
		/// <summary>
		/// Odkaz na stranku MainExpedition
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void expedition(object sender, EventArgs args)
		{

			await Navigation.PushModalAsync(new MainExpedition());
		}

		/// <summary>
		/// Odkaz na stranku MainArena
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void arena(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainArena());
		}

		/// <summary>
		/// Odkaz na stranku Games
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void players(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Users());
		}

		/// <summary>
		/// Odkaz na stranku MainShop
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void shop(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainShop());
		}
	}
}
