using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainInfo : ContentPage
	{

		public MainInfo()
		{
			InitializeComponent();
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

		}
		/// <summary>
		/// Návrat do menu
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void menu(object sender, EventArgs args)
		{
			Navigation.PopModalAsync();
		}
	}
}
