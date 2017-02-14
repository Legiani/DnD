using System;
using Xamarin.Forms;

namespace DnD
{
	public class Story
	{
		public Story()
		{

			showPageCommand(new MainShop());

		}

		public Page getStory()
		{
			return new Command((() =>
			{
				Navigation.PushAsync(page);
			}));


		}
	}
}
