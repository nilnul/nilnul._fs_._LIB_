using System.Collections.Generic;

namespace nilnul.fs._address.dir
{
	public class Eq :
		IEqualityComparer<DirI>
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
			return _dst.denote.Eq.Singleton.Equals(x.denote, y.denote);

			//throw new NotImplementedException();
		}

		//public int GetHashCode(DirName obj)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.avowed);
		//	//throw new NotImplementedException();
		//}


		public int GetHashCode(DirI obj)
		{
			return _dst.denote.Eq.Singleton.GetHashCode(obj.denote);

			//throw new NotImplementedException();
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
