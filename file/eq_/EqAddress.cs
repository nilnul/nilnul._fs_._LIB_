using System.Collections.Generic;

namespace nilnul.fs.file.eq_
{
	public class ByAddress : IEqualityComparer<nilnul.fs.FileI>
	{
		public bool Equals(FileI x, FileI y)
		{
			return nilnul.fs.address_.spear.Eq.Singleton.Equals(x.file.en, y.file.en);
			//throw new NotImplementedException();
		}

		public int GetHashCode(FileI obj)
		{
			return nilnul.fs.address_.spear.Eq.Singleton.GetHashCode(obj.file.en);
			//throw new NotImplementedException();
		}


		static public ByAddress Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ByAddress>.Instance;
			}
		}

	}
}
