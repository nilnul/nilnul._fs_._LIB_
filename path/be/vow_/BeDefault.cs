using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.be.vow_
{
	public class BeDefault<TBe> : path.be.Vow
		where TBe: nilnul.obj.BeI1<fs.IPath>,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<TBe>>.Instance;
			}
		}


	}
}
