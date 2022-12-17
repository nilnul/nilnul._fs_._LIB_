using System;
using System.Collections.Generic;

namespace nilnul.fs._address._dst.denote
{
	[Obsolete()]
	public class Eq :
		nilnul.obj.eq_.Homomorph<Denote, string, nilnul.txt.eq_.CaseInsensitive>
		,
		IEqualityComparer<Denote>
	{
		public Eq() : base(c => c.en)
		{
		}

		public bool eq(string x, string y)
		{
			return eq(new Denote(x), new Denote(y));
		}
		private bool _eq(string x, string y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x, y);
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
