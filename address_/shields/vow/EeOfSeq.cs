using nilnul.obj;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.fs.address_.shields.vow
{
	public class EeOfSeq : nilnul.obj.vow.Ee1<
		IEnumerable< nilnul.fs.address_.ShieldI>
	>
	{
		public EeOfSeq(ShieldsI val, nilnul.fs.address_.shields.VowOfSeqI vow) : base(val, vow)
		{
		}

		public EeOfSeq(IEnumerable<ShieldI> val, VowI2<IEnumerable<ShieldI>> vow) : base(val, vow)
		{
		}

	}
}
