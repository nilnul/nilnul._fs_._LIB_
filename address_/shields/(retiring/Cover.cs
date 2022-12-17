﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields
{
	[Obsolete()]
	static public class _CoverX
	{
		static public bool Cover(IEnumerable<address_.ShieldI> shields, address_.ShieldI shield)
		{
			return shields.Any( c=> address_.shield.re_.Sup.Singleton.re(c, shield) );
		}

		static public bool Cover(IEnumerable<string> shields, string shield) {
			return Cover(
				shields.Select(x=> address_.Shield.Parse(x))
				,
				address_.Shield.Parse(shield)
			);
		}

		static public bool Cover_inAddress(IEnumerable<string> shields, string shield) {
			return Cover(
				shields.Select(x=> address_.shield_._AddressX.Create(x))
				,
				address_.shield_._AddressX.Create(shield)
			);
		}

	}
}
