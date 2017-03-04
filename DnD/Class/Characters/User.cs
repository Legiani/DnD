using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DnD
{
	public class User : AEntity
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public int win { get; set; }
		public int lost { get; set; }
		public string focus { get; set; }

		public override string ToString()
		{
			return ID + " " + win + " " + lost + " " + life + " " + name+ "" + attack + "" + defense + "" + money+ "" +focus;
		}
	}
}
