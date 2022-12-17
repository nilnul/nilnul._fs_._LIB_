using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.comp_.privileged.re_
{
	public class Txt :

		nilnul.obj.comp.Re<string>


	{


		public Txt(nilnul.fs.address_.shields.be_.disjoint.vow.En ord) : base(new Privileged(ord))
		{
		}



		public Txt(IEnumerable<ShieldI> containers) : this(new nilnul.fs.address_.shields.be_.disjoint.vow.En(containers))
		{

		}

		public Txt(params string[] addresses) : this(
			addresses.Select(x => Shield.FroAddress(x) as ShieldI)
		)
		{

		}
	}
}
