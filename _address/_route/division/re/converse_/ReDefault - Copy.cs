using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.fs._address.division.re.converse_
{
	[Obsolete()]
	public class ReDefault<TRe> : nilnul.obj.re.Converse<nilnul.fs._address.DivisionI>
		,ReI
		where TRe:division.ReI,new()
	{
		public ReDefault() : base(nilnul.obj_.Singleton<TRe>.Instance)
		{
		}

		static public ReDefault<TRe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ReDefault<TRe>>.Instance;
			}
		}

	}


}
