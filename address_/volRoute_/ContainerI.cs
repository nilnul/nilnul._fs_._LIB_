using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_
{
	[Obsolete()]

	public interface ContainerI : VolRouteI,address_.ContainerI
	{
		nilnul.fs._address.route_.DeckedDiv deckedDiv
		{
			get;

		}
	}
}
