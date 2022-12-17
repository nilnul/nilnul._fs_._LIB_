using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.op_.unary
{
	static public class _ExtensionsX
	{
		static public nilnul.fs.address_.ShieldI Op_ofAddress(
			this nilnul.fs.address_.shield.op_.UnaryI unary
			,
			string x
		) {
			return unary.op(
				nilnul.fs.address_.shield_._AddressX1.Create(x)
			);
		}
		static public nilnul.fs.address_.ShieldI Op(
			this nilnul.fs.address_.shield.op_.UnaryI unary
			,
			nilnul.fs.AddressI x
		) {
			return unary.op(
				nilnul.fs.address_.shield_._AddressX1.Create(x)
			);
		}


	}
}
