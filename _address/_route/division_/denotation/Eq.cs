using nilnul.fs._address._route.division_.div;
using System.Collections.Generic;
using D = nilnul.fs._address.DocumentI;

namespace nilnul.fs._address._route.division_.denotation
{
	public class Eq
		: IEqualityComparer<D>
		,
		IEqualityComparer<
			_address._route.division_.div.DntedI
		>
		,
		IEqualityComparer<
			_address.DenotationI
		>

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

		public bool Equals(DenotationI x, DenotationI y)
		{
			return nilnul.fs._address.div.Eq.Singleton.Equals(x.div, y.div)
				&&
				nilnul.fs._address._route.division_._div._dir.dnt.Eq.Singleton.Equals(x.dnt, y.dnt)
				;

			
		}

		public int GetHashCode(DenotationI obj)
		{
			return nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div)
				&
				nilnul.fs._address._route.division_._div._dir.dnt.Eq.Singleton.GetHashCode(obj.dnt)
				;

			
		}

		public bool Equals(DntedI x, DntedI y)
		{
			return nilnul.fs._address._route.division_.div.Eq.Singleton.Equals(x.div, y.div)
				&&
				nilnul.fs._address._route.division_._div._dir.dnt.Eq.Singleton.Equals(x.dnt, y.dnt)
				;


			throw new System.NotImplementedException();
		}

		public int GetHashCode(DntedI obj)
		{
			throw new System.NotImplementedException();
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
