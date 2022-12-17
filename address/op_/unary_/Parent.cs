using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.op_.unary_
{
	static public class _ParentX
	{
		static public nilnul.fs.AddressI Parent(nilnul.fs.AddressI address) {
			switch (address)
			{
				case nilnul.fs.address_.ShieldI shield:
					return nilnul.fs.address_.shield.op_.unary_._ParentX._Op(shield);
				case nilnul.fs.address_.SpearI spear:
					return nilnul.fs.address_.spear._ContainerX.Shield(spear);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}
	}
}
