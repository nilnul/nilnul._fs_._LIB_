using System.Collections.Generic;

namespace nilnul.fs._address._dst.denote
{
	public class Comp : IComparer<Denote>
	{
		public int Compare(Denote x, Denote y)
		{
			return nilnul.txt.comp_.CaseInsentive.Singleton.Compare(x.ToString(), y.ToString());
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
