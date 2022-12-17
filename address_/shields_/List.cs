using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.address_.shield.str_
{
	public class Lst : List<nilnul.fs.address_.ShieldI>
		,
		shield.StrI
	{

		public Lst()
		{

		}

		public Lst(int capacity) : base(capacity)
		{
		}

		public Lst(IEnumerable<ShieldI> collection) : base(collection)
		{
		}

		public ShieldI[] toArr()
		{
			return this.ToArray();
		}
		public  bool contain(ShieldI shield) {
			return this.Any(x=> nilnul.fs.address_.shield.Eq.Singleton.Equals(x,shield));
		}
		public new bool Contains(ShieldI shield) {
			return contain(shield);
		}
		
	}
}
