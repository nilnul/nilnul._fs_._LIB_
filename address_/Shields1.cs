using System.Collections.Generic;

namespace nilnul.fs.address_
{
	public class Shields
		: nilnul.objs_.Enumable<nilnul.fs.address_.ShieldI>
		,
		ShieldsI
	{
		public Shields(IEnumerable<ShieldI> enumerable) : base(enumerable)
		{
		}

		public Shields() : this(new ShieldI[0])
		{

		}

		public override string ToString()
		{
			return nilnul.fs.address.str._PhraseX.Phrase(this);
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
