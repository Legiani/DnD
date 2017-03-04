using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class Shoper : ContentPage
	{
		Story story = new Story();
		public Shoper()
		{
			InitializeComponent();
			title.Text = "Potkal jsi obchodníka. Chceš ho oslovit?";
		}

		public void yes(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new MainShop());
		}

		public void no(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(story.getStory());
		}

		public void my(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new MainInfo());
		}
	}
}
