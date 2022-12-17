using System;
using System.Collections.Generic;

namespace nilnul.fs._address.doc_._exted.ext
{
	[Obsolete()]
	public class Eq :
		nilnul.obj.eq_.Homomorph<ExtI, string, nilnul.txt.nulable.eq_.CaseInsensitive>
		,
		IEqualityComparer<ExtI>

	{
		public Eq() : base(x => x.ToString())
		{
		}



		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}
		public bool eq(ExtI x, string y)
		{
			return Equals((x), new Ext(y));
		}

		public bool eq(string y, ExtI x)
		{
			return eq((x), new Ext(y));
		}

		public bool eq(string x, string y)
		{
			return Equals(new Ext(x), (y));
		}



	}
}