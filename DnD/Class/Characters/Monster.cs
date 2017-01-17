using System;
namespace DnD
{
	public class Monster : Entity
	{
		public Monster()
		{
		}
		public override string ToString()
		{
			return life +""+ attack +""+ defense +""+ name;
		}
	}
}
