using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.destination
{
	[Obsolete()]
	public class Dict<TVal> :nilnul.obj.Dict<nilnul.fs._address.DestinationI, TVal, destination.Eq>
		,
		nilnul.fs.IPac
	{

	}
}
