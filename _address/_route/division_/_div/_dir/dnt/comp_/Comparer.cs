using System.Collections.Generic;

namespace nilnul.fs._address._dst.denote.comp_
{
	public class Cn : IComparer<_dst.Denote>
	{
		public int Compare(Denote x, Denote y)
		{
			return nilnul.txt.comparer_.upperUp_.Cn.Singleton.Compare(x, y);
			//throw new NotImplementedException();
		}


		static public Cn Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cn>.Instance;
			}
		}

	}
}
