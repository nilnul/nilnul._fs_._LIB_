using System;
using System.Collections.Generic;
using D = nilnul.fs._address.DocumentI;

namespace nilnul.fs._address.document
{
	[Obsolete()]
	public class Eq
		: IEqualityComparer<D>
	{
		public bool Equals(D x, D y)
		{
			return nilnul.fs._address.div.Eq.Singleton.Equals(x.div, y.div)
				&&
				nilnul.fs._address.doc.Eq.Singleton.Equals(x.doc, y.doc)
				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(D obj)
		{
			return
nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div)
				&
				nilnul.fs._address.doc.Eq.Singleton.GetHashCode(obj.doc)
				;
			//throw new NotImplementedException();
		}



		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Eq>' is obsolete
				return nilnul._obj.Singleton<Eq>.Instance;
#pragma warning restore CS0612 // 'Singleton<Eq>' is obsolete
			}
		}



	}
}
