using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class City : ContentPage
	{
		Story story = new Story();
		public City()
		{
			InitializeComponent();
			title.Text = "V dály vidíš nejaké monumentální město chceš ho navštívit ?";
		}

		public void yes(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new MainCity());
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
