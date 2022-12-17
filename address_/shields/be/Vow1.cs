using nilnul.obj;
using System;
using System.Collections.Generic;

namespace nilnul.fs.address_.shields.be
{
	public class VowOfSeq
		:
		nilnul.obj.be.Vow4<IEnumerable<address_.ShieldI>>
		,
		address_.shields.VowOfSeqI
	{
		public VowOfSeq(BeI1<IEnumerable<ShieldI>> be) : base(be)
		{
		}

		public VowOfSeq(Predicate<IEnumerable<ShieldI>> predicate) : base(predicate)
		{
		}

		public VowOfSeq(Func<IEnumerable<ShieldI>, bool> func) : base(func)
		{
		}

		
	}
}
