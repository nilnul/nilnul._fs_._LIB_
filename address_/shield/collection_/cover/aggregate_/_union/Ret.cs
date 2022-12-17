using System.Collections.Generic;

namespace nilnul.fs.address_.shield.collection_.cover.aggregate_._union
{
	public class Ret
		: nilnul.obj.Box<IEnumerable<nilnul.fs.address_.ShieldI>>
		,
		nilnul.fs.address_.shield.CollectionI
	{
		public Ret(IEnumerable<ShieldI> val) : base(val)
		{
		}



		static public Ret OfAddresses(IEnumerable<string> shields)
		{
			return new Ret(shield.seq_._AddressesX.Seq(shields));
		}
		public bool contain(ShieldI element)
		{
			return _ret._ContainX.Cover(boxed, element);
			//throw new NotImplementedException();
		}


	}
}
