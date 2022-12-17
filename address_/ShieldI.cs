using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public interface ShieldI
		: _shield_.StemI,_address_.VolI
		,
		AddressI1
	{

	}

	[Obsolete()]
	public abstract class ShieldA : ShieldI
	{
		

		public abstract StemI1 stem { get; }
		public abstract VolI vol { get; }
		public  RouteI route { get { return stem; } }
	}
}
