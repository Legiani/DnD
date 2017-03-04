using System;
using Xamarin.Forms;

namespace DnD
{
	public class Story
	{
		public Story()
		{

		}

		public Page getStory()
		{
			Random rnd = new Random();
			int month = rnd.Next(1, 13);

			switch (rnd.Next(0, 5))
			{
				case 1:
					return new City();
				case 2:
					return new Entity();
				case 3:
					return new Shoper();
				default:
					return new Crossroads();
			}

		}

		public string gerDirection() 
		{ 
			Random rnd = new Random();
			int month = rnd.Next(0, 3);

			switch (rnd.Next(0, 5))
			{
				case 0:
					return "vpravo";
				case 1:
					return "vlevo";
				case 2:
					return "vpřed";
				default:
					return "vpřed";
			}
		}


	}
}
