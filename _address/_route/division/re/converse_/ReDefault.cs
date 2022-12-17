using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.fs._address._route.division.re.converse_
{
	public class ReDefault<TRe> : nilnul.obj.re.converse_.ReDefault<nilnul.fs._address._route.DivisionI, TRe>
		,ReI
		where TRe:division.ReI,new()
	{
		

		//static public ReDefault<TRe> Singleton
		//{
		//	get
		//	{
		//		return nilnul.obj_.Singleton<ReDefault<TRe>>.Instance;
		//	}
		//}

	}


}
