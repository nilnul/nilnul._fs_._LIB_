using System.Collections.Generic;

namespace nilnul.fs._address._route.division_.div
{
	public class Eq
		:
		IEqualityComparer<nilnul.fs._address.DivI>
		,
		IEqualityComparer<nilnul.fs._address._route.division_.DivI>


	{
		public bool Equals(DivI x, DivI y)
		{
			return nilnul.obj.str_.enumable.Eq<
				_address._route.division_._div.DirI
				,
				_address._route.division_._div.dir.Eq
				
			>.Singleton.Equals(x, y);

			//throw new NotImplementedException();
		}

		public int GetHashCode(DivI obj)
		{
#pragma warning disable CS0612 // 'Eq<DirI, Eq>' is obsolete
			return nilnul.obj.str_.enumable.Eq<_div.DirI, _div.dir.Eq>.Singleton.GetHashCode(obj);
#pragma warning restore CS0612 // 'Eq<DirI, Eq>' is obsolete
			//throw new NotImplementedException();
		}

		public bool Equals(_address.DivI x, _address.DivI y)
		{
			return nilnul.obj.str_.enumable.Eq<DirI, dir.Eq>.Singleton.Equals(x.dirs, y.dirs);

			throw new System.NotImplementedException();
		}

		public int GetHashCode(_address.DivI obj)
		{
			return nilnul.obj.str_.enumable.Eq<DirI, dir.Eq>.Singleton.GetHashCode(obj.dirs);
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
