using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainArena : ContentPage
	{
		User user;

		Monster monster;

		public MainArena(User user)
		{
			InitializeComponent();
			this.user = user;

			monster = new Monster() { name=randomName(), attack=random(user.attack-10), defense=random(user.defense - 10), life=random(0,1,3), money=random(0,2,5) };


		}
		public void fill() {
			monster1.Text = monster.name;
			player.Text = user.name;

			p_life.Text = user.life;

			m_life.Text = monster.life;
			m_attack.Text = monster.attack;
			m_defense.Text = monster.defense;

		}

		public void attack(object sender, EventArgs args)
		{
			if (random(0, 0, 1) == 1)
			{
				if (monster.defense - user.attack >= 0)
				{
					monster.defense = monster.defense - user.attack;
				}
				else {
					if (monster.life > 1)
					{
						monster.life = monster.life - 1;
					}
					else {
						user.money = user.money + monster.money;
						Navigation.PushModalAsync(new MainInfo(user, 1));
					}
				}
			}
			else{
				if (user.defense - monster.attack >= 0)
				{
					user.defense = user.defense - monster.attack;
				}
				else {
					if (user.life > 1)
					{
						user.life = user.life - 1;
					}
					else {
						Navigation.PushModalAsync(new MainInfo(user, 0));
					}
				}
			}
		}


		public void defense(object sender, EventArgs args)
		{
			if (user.defense - monster.attack >= 0)
			{
				user.defense = user.defense - monster.attack;
			}
			else {
				if (user.life > 1)
				{
					user.life = user.life - 1;
				}
				else {
					Navigation.PushModalAsync(new MainInfo(user, 0));
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
					return rnd.Next() % 2;
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
