using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.element_
{
	public class AddressVowed
		:
		nilnul.fs.address.be_.element.vow.En1
		,
		ElementI1
	{
		public AddressVowed(AddressI1 val) : base(val)
		{
		}

		public AddressVowed(string x):this(
			nilnul.fs.address_._TxtX.By(x)
		)
		{

		}

		public VolI vol => en.vol;

		public RouteI route => en.route;

		public _address.route_.SprigI sprig => new nilnul.fs._address.route_.Sprig1( route);
	}
}
