using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class Crossroads : ContentPage
	{
		Story story = new Story();
		public Crossroads()
		{
			InitializeComponent();
			title.Text = string.Format("Chceš jít {0}", story.gerDirection());
		}

		public void yes(object sender, EventArgs args)
		{
			Navigation.PushModalAsync( story.getStory() );
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
