using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.containers.be_.disjoint.vow
{
	[Obsolete()]
	public class En
		:
		nilnul.fs.address_.containers.vow.En<nilnul.fs.address_.containers.be_.disjoint.Vow>

	{
		public En(address_.ContainersI val) : base(val)
		{
		}

		public En(IEnumerable<ContainerI1> val):this( new address_.Containers(val))
		{

		}
	}
}
