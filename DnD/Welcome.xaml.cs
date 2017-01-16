using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
public partial class Welcome : ContentPage
	{
		public virtual Color ForeColor { get; set; }

		/// <summary>
		/// Inicializuje novou třídu
		/// Mění barvu "vstoupit" --> vzniká blikání
		/// </summary>
		public Welcome()
		{
			InitializeComponent();

			var whitetoblack = false;
			button.Animate(
				"colorchange",
				x =>
				{
					if (whitetoblack)
						x = 1 - x;
					var test = (int)(254 * x);

					button.TextColor = Color.FromRgb(test, test, test);
				},
				length: 3000,
				finished: delegate (double d, bool b)
				{
					if (!whitetoblack)
						button.TextColor = Color.FromRgb(60, 90, 80);
					else
						button.TextColor = Color.FromRgb(255, 255, 255);
				},
				repeat: () =>
				{
					whitetoblack = !whitetoblack;
					return true;
				}
			);


		}

		/// <summary>
		/// start zobrazí vypis hráču
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public void start(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new Users());
		}

	}
}
