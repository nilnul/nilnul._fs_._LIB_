﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields.divisions.find
{
	static public class _LogX_ofPredicate
	{
		static public string LogSpear(
			IEnumerable<ShieldI> shields
			, Predicate<string> predicate,
			string logKey
		)
		{
			return nilnul.fs.folders.divisions.find._LogX_ofPredicate.LogSpear(
				shields.Select(
					s => nilnul.fs.folder.nulable._ParseX.Ov(s)
				).Where(
					f => f != null
				)
				,
				predicate
				,
				logKey
			);
		}


		public static string LogSpear(IEnumerable<AddressI> addresses, Predicate<string> predicate, string v)
		{
			return LogSpear(
				addresses.Select(a => nilnul.fs.address_.shield_._AddressX1.Create(a))
				,
				predicate
				,
				v
			);
		}

		static public string LogSpear(IEnumerable<string> shields, Predicate<string> predicate, string logKey)
		{
			return nilnul.fs.folders.divisions.find._LogX_ofPredicate.LogSpear(
				shields.Select(
					s => nilnul.fs.folder.nulable._ParseX.Parse(s)
				).Where(
					f => f != null
				)
				,
				predicate
				,
				logKey
			);
		}



	}
}