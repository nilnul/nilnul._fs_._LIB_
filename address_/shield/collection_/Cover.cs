using System.Collections.Generic;

namespace nilnul.fs.address_.shield.collection_
{
	/// <summary>
	/// the shield and any shield that's the sub of it
	/// </summary>
	public class Cover
		:
		nilnul.obj.Box<IEnumerable<nilnul.fs.address_.ShieldI>>
		,
		nilnul.fs.address_.shield.CollectionI
	{
		public Cover(IEnumerable<ShieldI> val) : base(val)
		{
		}



		static public Cover OfAddresses(IEnumerable<string> shields)
		{
			return new Cover(shield.seq_._AddressesX.Seq(shields));
		}
		public bool contain(ShieldI element)
		{
			return _cover_._ContainX.Cover(boxed, element);
			//throw new NotImplementedException();
		}


	}
}
