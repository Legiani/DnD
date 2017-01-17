using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainInfo : ContentPage
	{
		User user;
		bool v;

		public MainInfo(User user, bool v)
		{
			InitializeComponent();

			this.user = user;
			this.v = v;

			fill();
		}

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

		public void menu(object sender, EventArgs args)
		{
			Game game = new Game();
			Navigation.PushModalAsync(new MainStory(user, game));
		}
	}
}
