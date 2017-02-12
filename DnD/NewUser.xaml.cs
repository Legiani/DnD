using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class NewUser : ContentPage
	{
		User user = new User();
		int Free = 10;
		int def = 0;
		int ata = 0;
		int hea = 0;
		double x;

		public NewUser()
		{
			InitializeComponent();
			free.Text = Free.ToString();
			d.Text = def.ToString();
			a.Text = ata.ToString();
			h.Text = hea.ToString();

			x = ata / 10.0;
			attack.Progress = x;
			x = def / 10.0;
			defence.Progress = x;
			x = def / 10.0;
			healt.Progress = x;

		}

		public void chan(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("+++++++++++");
			System.Diagnostics.Debug.WriteLine(sampon.Text.Length);
			System.Diagnostics.Debug.WriteLine(sampon.Text);
			System.Diagnostics.Debug.WriteLine("+++++++++++");
			if (sampon.Text.Length > 3)
			{
				user.name = sampon.Text;
			}
		}



		public void hplus(object sender, EventArgs e)
		{
			if (Free >= 1)
			{
				Free = Free - 1;
				hea = hea + 1;
			}
			x = def / 10.0;
			healt.Progress = x;
			h.Text = hea.ToString();
			fill();
		}
		public void hminus(object sender, EventArgs e)
		{
			if (hea >= 1)
			{
				Free = Free + 1;
				hea = hea - 1;
			}
			x = def / 10.0;
			healt.Progress = x;
			h.Text = hea.ToString();
			fill();
		}
		public void aplus(object sender, EventArgs e)
		{
			if (Free >= 1)
			{
				Free = Free - 1;
				ata = ata + 1;
			}
			x = ata / 10.0;
			attack.Progress = x;
			a.Text = ata.ToString();
			fill();
		}
		public void aminus(object sender, EventArgs e)
		{
			if (ata >= 1)
			{
				Free = Free + 1;
				ata = ata - 1;
			}
			x = ata / 10.0;
			attack.Progress = x;
			a.Text = ata.ToString();
			fill();
		}
		public void dplus(object sender, EventArgs e)
		{
			if (Free >= 1)
			{
				Free = Free - 1;
				def = def + 1;
			}
			x = def / 10.0;
			defence.Progress = x;
			d.Text = def.ToString();
			fill();
		}
		public void dminus(object sender, EventArgs e)
		{
			if (def >= 1)
			{
				Free = Free + 1;
				def = def - 1;
			}
			x = def / 10.0;
			defence.Progress = x;
			d.Text = def.ToString();
			fill();
		}



		public void Archer(object sender, EventArgs args)
		{
			user.focus = "Archer";
		}

		public void Warrior(object sender, EventArgs args)
		{
			user.focus = "Warrior";
		}

		public void Magic(object sender, EventArgs args)
		{
			user.focus = "Magic";
		}


		public void fill() { 
			free.Text = Free.ToString();

			System.Diagnostics.Debug.WriteLine(user.name);
			System.Diagnostics.Debug.WriteLine(user.focus);
			System.Diagnostics.Debug.WriteLine(Free);

			if (user.name != null && user.focus != null && Free == 0) {
				saveEnable.IsEnabled = true;
			}
		}

		public void save(object sender, EventArgs args)
		{
			var dbConnection = App.Database;
			UsersDatabase userDatabase = App.Database;
			App.Database.SaveItemAsync(user);

			Navigation.PushModalAsync(new Users());
		}



	}
}
