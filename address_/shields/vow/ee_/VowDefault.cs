using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.vow.ee_
{
	public class VowDefaultOfSeq<TVow> : shields.vow.EeOfSeq
		where TVow : shields.VowOfSeqI, new()
	{
		public VowDefaultOfSeq(ShieldsI val) : this( (IEnumerable<ShieldI>) val)
		{
		}

		public VowDefaultOfSeq(IEnumerable<ShieldI> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
