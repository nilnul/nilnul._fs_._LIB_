using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_
{
	/// <summary>
	/// there is an separator at the end and the begining. 
	/// </summary>
	/// 
	[Obsolete()]
	public interface StemI1
		:RouteI
	{

		_address.DivI1 div
		{
			get;
		}

	}

	[Obsolete()]
	public abstract class StemA : StemI1
	{
		public abstract DivI1 div { get; }
		public  DivisionI division { get { return div; } }
	}

}
