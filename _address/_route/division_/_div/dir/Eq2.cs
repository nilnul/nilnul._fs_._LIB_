using System.Collections.Generic;

namespace nilnul.fs._address._route.division_._div.dir
{
	public class Eq :
		IEqualityComparer<DirI>
		,
		IEqualityComparer<_address.DirI>
	//,

	//IEqualityComparer<DirName>
	{
		//public bool Equals(DirName x, DirName y)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.avowed, y.avowed);
		//	//throw new NotImplementedException();
		//}
		public bool Equals(DirI x, DirI y)
		{
			return _dir.dnt.Eq.Singleton.Equals(x.caption, y.caption);

			//throw new NotImplementedException();
		}

		//public int GetHashCode(DirName obj)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.avowed);
		//	//throw new NotImplementedException();
		//}


		public int GetHashCode(DirI obj)
		{
			return _dir.dnt.Eq.Singleton.GetHashCode(obj.caption);

			//throw new NotImplementedException();
		}

		public bool Equals(_address.DirI x, _address.DirI y)
		{
			return _dst.denote.Eq.Singleton.Equals(x.denote, y.denote);
		}

		public int GetHashCode(_address.DirI obj)
		{
			return _dst.denote.Eq.Singleton.GetHashCode(obj.denote);
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
