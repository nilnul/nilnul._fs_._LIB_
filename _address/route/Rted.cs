using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route
{
	/// <summary>
	/// a route that is directly prefixed by origin/vol;
	/// 
	/// </summary>
	public interface RtedI:RouteI
	{

	}

	public class Rted :
		obj.Box<RouteI>,
		RtedI
	{
		public Rted(RouteI val) : base(val)
		{
		}

		public DivisionI division => boxed.division;
	}
}
