using System;
namespace DnD
{
	public class Game
	{
		private string name;
		private string owner;
		private DateTime createTime;
		private int time;

		public Game()
		{
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public DateTime CreateTime
		{
			get
			{
				return createTime;
			}

			set
			{
				createTime = value;
			}
		}


		public string Owner
		{
			get
			{
				return owner;
			}

			set
			{
				owner = value;
			}
		}

		public int Time
		{
			get
			{
				return time;
			}

			set
			{
				time = value;
			}
		}
	}
}
