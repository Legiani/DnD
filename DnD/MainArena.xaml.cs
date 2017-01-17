using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainArena : ContentPage
	{
		User user;
		int loop;
		Monster monster;
		int def;
		public MainArena(User user)
		{
			InitializeComponent();
			this.user = user;

			def = user.defense;
			monster = new Monster() { name=randomName(), attack=random(user.attack-10), defense=random(user.defense - 10), life=random(0,1,3), money=random(0,2,5) };
			fill();

		}
		public void fill() {
			monster1.Text = monster.name;
			player.Text = user.name;

			p_life.Text = "" + user.life;
			p_attack.Text = "" + user.attack;
			p_defense.Text = "" + user.defense;

			m_life.Text = "" + monster.life;
			m_attack.Text = "" + monster.attack;
			m_defense.Text = "" + monster.defense;

		}

		public async void attack(object sender, EventArgs args)
		{
			loop = loop + 1;
			if (random(0, 0, 1) == 1 || loop % 2 == 0)
			{
				if (monster.defense - user.attack >= 0)
				{
					monster.defense = monster.defense - user.attack;
					fill();
				}
				else {
					if (monster.life > 1)
					{
						monster.life = monster.life - 1;
						monster.defense = random(def - 10);
						fill();
					}
					else {
						user.money = user.money + monster.money;

						await Navigation.PushModalAsync(new MainInfo(user, true));
					}
				}
			}
			else{
				if (user.defense - monster.attack >= 0)
				{
					user.defense = user.defense - monster.attack;
					fill();
				}
				else {
					if (user.life > 1)
					{
						user.life = user.life - 1;
						user.defense = random(def - 10);
						fill();
					}
					else {
						
						await Navigation.PushModalAsync(new MainInfo(user, false));
					}
				}
			}
		}


		public async void defense(object sender, EventArgs args)
		{
			loop = loop + 1;
			if (user.defense - monster.attack >= 0)
			{
				user.defense = user.defense - monster.attack;
				fill();
			}
			else {
				if (user.life > 1)
				{
					user.life = user.life - 1;
					user.defense = random(def - 10);
					fill();
				}
				else {
					
					await Navigation.PushModalAsync(new MainInfo(user, false));
				}
			}
		}

		public string randomName() { 
			List<string> names = new List<string>();

			names.Add("Balmur");
			names.Add("Kaplouch");
			names.Add("Wemid");
			names.Add("Hujtal");
			names.Add("Egzos");
			names.Add("Anur");
			names.Add("Omior");

			Random rnd = new Random();
			string name = names[rnd.Next(0, names.Count)];
			return name;

		}

		public int random(int cca = 0, int min = 0, int max = 0) { 
			Random rnd = new Random();
			if (cca == 0)
			{
				if (min == 0 && max == 1)
				{
					if (rnd.Next() % 2 == 1)
					{
						return rnd.Next() % 2;
					}
					else {
						return 0;
					}
				}
				else {
					return rnd.Next(min, max);
				}
			}
			else { 
				
				return rnd.Next(cca - 10 , cca + 10);
			}

		
		}
	}
}
