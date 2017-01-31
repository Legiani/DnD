using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainInfo : ContentPage
	{
		User user;
		//promená se stavem víhra/prohra
		bool v;

		/// <summary>
		///  Inicializuje novou instanci se vstupem "user", a "v" vyhra/prohra 
		/// </summary>
		/// <param name="user">User.</param>
		/// <param name="v">If set to <c>true -> výhra</c></c> v.</param>
		public MainInfo(User user, bool v)
		{
			InitializeComponent();

			this.user = user;
			this.v = v;


			fill();
		}
		/// <summary>
		/// Výpis do XAML
		/// </summary>
		public void fill()
		{
			player.Text = user.name;

			p_life.Text = "" + user.life;
			p_attack.Text = "" + user.attack;
			p_defense.Text = "" + user.defense;
			p_money.Text = "" + user.money;

			if (v) {
				result.Text = "Víhra";
			} else {
				result.Text = "Prohra";
			}

		}
		/// <summary>
		/// Návrat do menu
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void menu(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new MainStory(user));
		}
	}
}
