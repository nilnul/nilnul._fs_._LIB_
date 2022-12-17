using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.fs._address.route.re.complement_
{
	public class ReDefault<TRe> : nilnul.obj.re.complement_.ReDefault<nilnul.fs._address.RouteI1, TRe>
		,
		ReI1
		where TRe:route.ReI1,new()
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
