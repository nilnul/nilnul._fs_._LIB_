using System.Collections.Generic;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext
{
	public class Eq :
		nilnul.obj.eq_.homo_.EqDefault<ExtI, string, nilnul.txt.nulable.eq_.CaseInsensitive>
		,
		IEqualityComparer<ExtI>

	{
		public Eq() : base(x => x.ToString())
		{
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


		static public Eq Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Eq>.Instance;
			}
		}
		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}




	}
}