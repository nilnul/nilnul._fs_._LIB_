using System.Collections.Generic;

namespace nilnul.fs.address_.shield.collection_
{
	/// <summary>
	/// </summary>
	public class Set
		:
		nilnul.obj.Box<nilnul.fs.address_.shield.Set>
		,
		nilnul.fs.address_.shield.CollectionI
	{
		public Set(shield.Set val) : base(val)
		{
		}

		public Set(IEnumerable<nilnul.fs.address_.ShieldI> shields) : this(new shield.Set(shields))
		{

		}

		public bool contain(ShieldI element)
		{
			return boxed.Contains(element);
			//throw new NotImplementedException();
		}

		static public Set OvAddresses(IEnumerable<string> addresses)
		{
			return new Set(
				nilnul.fs.address_.shield.Set.FroAddresses(
					addresses
				)
			);
		}

		static public Set OvShields(IEnumerable<string> shields)
		{
			return new Set(
				nilnul.fs.address_.shield.Set.OvShields(
					shields
				)
			);
		}



	}
}
