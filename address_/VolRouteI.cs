using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public interface VolRouteI:AddressI
	{


		 nilnul.fs._address.VolI vol
		{
			get;
		}


		 nilnul.fs._address.RouteI route
		{
			get;
		}


	}
}
