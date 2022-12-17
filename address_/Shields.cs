using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class Shields
		: nilnul.objs_.Enumable<nilnul.fs.address_.ShieldI>
		,
		ShieldsI
	{
		public Shields(IEnumerable<ShieldI> enumerable) : base(enumerable)
		{
		}

		public Shields():this( new ShieldI[0])
		{

		}

		public override string ToString()
		{
			return nilnul.obj.str.to_._txt.Extensions.ToLines(this);
		}
	}

	//public class Containers : nilnul.objs_.Enumable<ContainerI1>
	//	, ContainersI
	//{
	//	public Containers(IEnumerable<ContainerI1> enumerable) : base(enumerable)
	//	{
	//	}

	//}
}
