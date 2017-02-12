using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainArena : ContentPage
	{
		

		//počet kol duelu
		int loop;
		Monster monster;

		//zakladní obrana toho boje
		int def;
		/// <summary>
		///  Inicializuje novou instanci se vstupem user
		/// </summary>
		/// <param name="user">User.</param>
		public MainArena()
		{
			InitializeComponent();
		

			def = App.player.defense;
			monster = new Monster() { name=randomName(), attack=random(App.player.attack-10), defense=random(App.player.defense - 10), life=random(0,1,3), money=random(0,2,5) };
			fill();

		}

		/// <summary>
		/// Vloží data do stránk XAML
		/// </summary>
		public void fill() {
			monster1.Text = monster.name;
			player.Text = App.player.name;

			p_life.Text = "" + App.player.life;
			p_attack.Text = "" + App.player.attack;
			p_defense.Text = "" + App.player.defense;

			m_life.Text = "" + monster.life;
			m_attack.Text = "" + monster.attack;
			m_defense.Text = "" + monster.defense;

		}

		/// <summary>
		/// Pokus o utok muře a nemusí vijít na zakladě náhody
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void attack(object sender, EventArgs args)
		{
			loop = loop + 1;
			if (random(0, 0, 1) == 1 || loop % 2 == 0)
			{
				if (monster.defense - App.player.attack >= 0)
				{
					monster.defense = monster.defense - App.player.attack;
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
						App.player.money = App.player.money + monster.money;

						await Navigation.PushModalAsync(new MainInfo(true));
					}
				}
			}
			else{
				if (App.player.defense - monster.attack >= 0)
				{
					App.player.defense = App.player.defense - monster.attack;
					fill();
				}
				else {
					if (App.player.life > 1)
					{
						App.player.life = App.player.life - 1;
						App.player.defense = random(def - 10);
						fill();
					}
					else {
						
						await Navigation.PushModalAsync(new MainInfo(false));
					}
				}
			}
		}

		/// <summary>
		/// Pokus o obranu muře a nemusí vijít na zakladě náhody
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public async void defense(object sender, EventArgs args)
		{
			loop = loop + 1;
			if (App.player.defense - monster.attack >= 0)
			{
				App.player.defense = App.player.defense - monster.attack;
				fill();
			}
			else {
				if (App.player.life > 1)
				{
					App.player.life = App.player.life - 1;
					App.player.defense = random(def - 10);
					fill();
				}
				else {
					
					await Navigation.PushModalAsync(new MainInfo(false));
				}
			}
		}

		/// <summary>
		/// Výstupem je nahodné jméno z Listu names
		/// </summary>
		/// <returns>The name.</returns>
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

		/// <summary>
		/// Upravení funkce pro lepší práci 
		/// </summary>
		/// <param name="cca">vyhodí náhodné číslo +-10 od puvodního</param>
		/// <param name="min">Minimum.</param>
		/// <param name="max">Max.</param>
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
