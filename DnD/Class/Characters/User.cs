using System;
namespace DnD
{
	public class User : Entity
	{
		public int win { get; set; }
		public int lost { get; set; }
		public User()
		{

		}

		public override string ToString()
		{
			return win + " " + lost + " " + life + " " + name;
		}
	}
}
