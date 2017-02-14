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
			Random rnd = new Random();
			int month = rnd.Next(1, 13);

			switch (rnd.Next(0, 5))
			{
				case 1:
					Console.WriteLine("Case 1");
					break;
				case 2:
					Console.WriteLine("Case 2");
					break;
				default:
					Console.WriteLine("Default case");
					break;
			}

		}
	}
}
