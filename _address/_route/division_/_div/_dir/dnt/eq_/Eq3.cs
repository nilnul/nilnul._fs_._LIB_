using System.Collections.Generic;
using D = nilnul.fs._address.DocI;

namespace nilnul.fs._address.doc
{
	public class Eq : IEqualityComparer<D>
	{
		private bool _eq(string x, string y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x, y);
		}

		public bool Equals(D x, D y)
		{
			return _eq(x.ToString(), y.ToString());
			//throw new NotImplementedException();
		}
		public bool Equals(string x, string y)
		{
			return Equals(new Doc(x) as D, new Doc(y) as D);
		}

		public bool eq(D x, string y)
		{
			return Equals(x, new _address.Doc(y));
			//throw new NotImplementedException();
		}

		public bool eq(string x, D y)
		{
			return eq(y,x);
			//throw new NotImplementedException();
		}

		public int GetHashCode(D obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());

			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Eq>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
