using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.be_.disjoint.vow
{
	[Obsolete()]
	public class En
		:
		nilnul.fs.address_.shields.vow.En<nilnul.fs.address_.shields.be_.disjoint.Vow>

	{
		public En(address_.ShieldsI val) : base(val)
		{
		}

		public En(IEnumerable<ShieldI> val):this( new address_.Shields(val))
		{

		}
	}
}
