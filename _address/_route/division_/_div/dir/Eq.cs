using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir
{
	[Obsolete()]
	public class Eq1 : 
		IEqualityComparer<DirI1>
		//,
		
		//IEqualityComparer<DirName>
	{
		//public bool Equals(DirName x, DirName y)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.avowed, y.avowed);
		//	//throw new NotImplementedException();
		//}
		public bool Equals(DirI1 x, DirI1 y)
		{
			return doc.Eq2.Singleton.Equals(x.name, y.name);

			//throw new NotImplementedException();
		}

		//public int GetHashCode(DirName obj)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.avowed);
		//	//throw new NotImplementedException();
		//}


		public int GetHashCode(DirI1 obj)
		{
			return doc.Eq2.Singleton.GetHashCode(obj.name);

			//throw new NotImplementedException();
		}



		static public Eq1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq1>.Instance;
			}
		}



	}
}
