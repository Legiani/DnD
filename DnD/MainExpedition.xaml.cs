using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainExpedition : ContentPage
	{
		
		/// <summary>
		///  Inicializuje novou instanci se vstupem user 
		/// </summary>
		/// <param name="user">User.</param>
		public MainExpedition()
		{
			InitializeComponent();
	
		}

		/// <summary>
		/// Vrátí se zpět do menu
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void menu(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainStory());
		}
	}
}
