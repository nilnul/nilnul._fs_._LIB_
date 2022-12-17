using System.Collections.Generic;

namespace nilnul.fs.address_.shields.be_.disjoint.vow
{
	public class EeOfSeq
		:
		nilnul.fs.address_.shields.vow.ee_.VowDefaultOfSeq<nilnul.fs.address_.shields.be_.disjoint.Vow>

	{
		public EeOfSeq(address_.ShieldsI val) : base(val)
		{
		}

		public EeOfSeq(IEnumerable<ShieldI> val) : this(new address_.Shields(val))
		{

		}
	}
}
