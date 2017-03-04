using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class Entity : ContentPage
	{
		Story story = new Story();
		public Entity()
		{
			InitializeComponent();
			title.Text = "Objevila se před tebou přišera. Chceš zautočit?";
		}

		public void yes(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new MainArena());
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
