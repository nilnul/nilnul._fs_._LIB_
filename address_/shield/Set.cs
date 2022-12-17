using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield
{
	public class Set
		: nilnul.obj.Set<nilnul.fs.address_.ShieldI, nilnul.fs.address_.shield.Eq>
	{
		public Set()
		{

		}
		public Set(IEnumerable<nilnul.fs.address_.ShieldI> shields) : base(shields)
		{

		}

		public bool contain_ofAddress(string x)
		{
			return Contains(nilnul.fs.address_.shield_._AddressX1.Create(x));
		}

		static public Set FroAddresses(IEnumerable<string> addresses)
		{
			return new Set(
				addresses.Select(
					x => nilnul.fs.address_.Shield.FroAddress(x)
				)
			);
		}

		static public Set OvShields(IEnumerable<string> shields)
		{
			return new Set(
				shields.Select(
					x => nilnul.fs.address_.Shield.Parse(x)
				)
			);
		}


	}
}
