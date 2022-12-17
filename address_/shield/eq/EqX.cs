using System.Collections.Generic;

namespace nilnul.fs.address_.shield.eq
{
	static public class _ExtensionsX
	{
		static public bool Eq_ofAddress(this IEqualityComparer<nilnul.fs.address_.ShieldI> eq
			,
			nilnul.fs.address_.ShieldI x1
			,
			string y
		)
		{
			return eq.Equals(
				(x1)
				,
				nilnul.fs.address_.shield_._AddressX1.Create(y)
			);
		}
		static public bool Eq_ofAddress(
			this IEqualityComparer<nilnul.fs.address_.ShieldI> eq
			,
			string x
			,
			nilnul.fs.address_.ShieldI y
		)
		{
			return Eq_ofAddress(
				eq,
				y
				,
				x
			);
		}
		static public bool Eq_ofAddresses(
			this IEqualityComparer<nilnul.fs.address_.ShieldI> eq
			,
			string x
			,
			string y
		)
		{
			return Eq_ofAddress(
				eq
				,
				nilnul.fs.address_.shield_._AddressX1.Create(x)
				,
				(y)
			);
		}
	}
}