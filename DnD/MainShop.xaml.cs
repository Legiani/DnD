using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainShop : ContentPage
	{
		
		/// <summary>
		///  Inicializuje novou instanci se vstupem "user"
		/// </summary>
		/// <param name="user">User.</param>
		public MainShop()
		{
			InitializeComponent();

		}

		/// <summary>
		/// Návrat do menu
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void menu(object sender, EventArgs args)
		{
			
			await Navigation.PushModalAsync(new MainStory());
		}
	}
}
