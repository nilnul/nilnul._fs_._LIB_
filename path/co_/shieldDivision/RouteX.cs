using nilnul.fs._address.division.co._duct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.co_.shieldDivision
{
	/// <summary>
	/// get the relpath of two files.
	/// </summary>
	static public class _ConcatX
	{

		static public nilnul.fs.path_.Full Full(nilnul.fs.address_.ShieldI origin, nilnul.fs.path_.contextual_.DivisionI route)
		{
			return new nilnul.fs.path_.Full(
				origin.vol
				,
				 path_.Rted.Ov(
					origin.stem
					,
					route
				)
			);
		}

		static public nilnul.fs.AddressI  Address(nilnul.fs.address_.ShieldI origin, nilnul.fs.path_.contextual_.DivisionI route)
		{
			return Full(origin,route).toAddress();
		}

	
	}

	
}
