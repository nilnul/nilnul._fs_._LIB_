using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.comp_.privileged
{
	public class Re :

		nilnul.obj.comp.Re<ShieldI>


	{
		public Re(IComparer<ShieldI> ord) : base(ord)
		{
		}

		public Re(nilnul.fs.address_.shields.be_.disjoint.vow.En ord) : base(new Privileged(ord))
		{
		}



		public Re(IEnumerable<ShieldI> containers) : this(new nilnul.fs.address_.shields.be_.disjoint.vow.En(containers))
		{

		}

		public Re(params string[] addresses) : this(
			addresses.Select(x => Shield.FroAddress(x) as ShieldI)
		)
		{

		}
	}
}
