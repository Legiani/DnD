using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainInfo : ContentPage
	{

		//promená se stavem víhra/prohra
		bool v;

		/// <summary>
		///  Inicializuje novou instanci se vstupem "user", a "v" vyhra/prohra 
		/// </summary>
		/// <param name="user">User.</param>
		/// <param name="v">If set to <c>true -> výhra</c></c> v.</param>
		public MainInfo(bool v)
		{
			InitializeComponent();

			this.v = v;



		}
		/// <summary>
		/// Výpis do XAML
		/// </summary>
		public void fill()
		{
			player.Text = App.player.name;

			p_life.Text = "" + App.player.life;
			p_attack.Text = "" + App.player.attack;
			p_defense.Text = "" + App.player.defense;
			p_money.Text = "" + App.player.money;

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
			Navigation.PushModalAsync(new MainStory());
		}
	}
}
