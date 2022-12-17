using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.be.vow_
{
	public class VowDefaultOfSeq<TBe> : folders.be.VowOfSeq
		where TBe : nilnul.fs.folders.BeOfSeqI, new()
	{
		public VowDefaultOfSeq() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public VowDefaultOfSeq<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<VowDefaultOfSeq<TBe>>.Instance;
			}
		}



	}
}
