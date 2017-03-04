using System;
namespace DnD
{
	public class Monster : AEntity
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
