using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.be.vow_
{
	public class BeDefaultOfSeq<TBe> : shields.be.VowOfSeq
		where TBe : nilnul.fs.address_.shields.BeI1, new()
	{
		public BeDefaultOfSeq() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefaultOfSeq<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaultOfSeq<TBe>>.Instance;
			}
		}



	}
}
