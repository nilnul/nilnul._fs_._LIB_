using nilnul.fs._address;

namespace nilnul.fs.address_.spear_
{
	public class AddressVowen
		:
		nilnul.fs.address.be_.spear.vow.En1
		,
		SpearI
	{
		public AddressVowen(AddressI val) : base(val)
		{
		}

		public AddressVowen(string x) : this(
			nilnul.fs.address_._TxtX.By(x)
		)
		{

		}

		public VolI vol => en.vol;

		public RouteI route => en.route;

		public _address.route_.SprigI sprig => nilnul.fs._address.route_.SprigA.Downcast(route);
	}
}
