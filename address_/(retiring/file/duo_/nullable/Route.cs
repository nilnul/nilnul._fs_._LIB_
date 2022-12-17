using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.file.duo_.nullable
{
	static public class RouteX
	{
		static duo.RouteI Eval(nilnul.fs.address_.File origin, nilnul.fs.address_.File target) {

			if (origin==null)
			{
				return new duo.route_.Abs(target);
			}
			if (target==null)
			{
				return null;
			}
			return file.duo.RouteX.GetRoute(origin,target);
		}
	}
}
