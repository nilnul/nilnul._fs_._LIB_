using System.Collections.Generic;

namespace nilnul.fs._address.dir
{
	public class Comp : IComparer<DirI>
	{
		public int Compare(DirI x, DirI y)
		{

			return _dst.denote.Comp.Singleton.Compare(x.denote, y.denote);
			//throw new NotImplementedException();
		}



		static public Comp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comp>.Instance;
			}
		}


	}
}
