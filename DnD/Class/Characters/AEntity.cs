using System;
namespace DnD
{
	public abstract class Entity
	{
		public string name { get; set; }
		public int attack { get; set; }
		public int defense { get; set; }
		public int life { get; set; }
		public int money { get; set; }

		public Entity()
		{
		}
	}
}
