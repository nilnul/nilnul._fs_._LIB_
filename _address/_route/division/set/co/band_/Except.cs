﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.set.co.band_
{
	/// <summary>
	/// </summary>
	static public class _ExceptX
	{
		static public  division.Set Band(
			division.Set a
			,
			division.Set b

		) {
			return new Set(
				a.Except(b, nilnul.fs._address.division.Eq.Singleton).ToArray()
			);
		}
	}
}
