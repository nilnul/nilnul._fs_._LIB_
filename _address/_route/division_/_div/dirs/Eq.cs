using System.Collections.Generic;

namespace nilnul.fs._address.dirs
{
#pragma warning disable CS0612 // 'DirsI' is obsolete
	public class Eq : IEqualityComparer<nilnul.fs._address.DirsI>
#pragma warning restore CS0612 // 'DirsI' is obsolete
	{
#pragma warning disable CS0612 // 'DirsI' is obsolete
#pragma warning disable CS0612 // 'DirsI' is obsolete
		public bool Equals(DirsI x, DirsI y)
#pragma warning restore CS0612 // 'DirsI' is obsolete
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{
			return nilnul.objs_.enumerable.Eq<DirI, dir.Eq>.Singleton.Equals(x, y);

			//throw new NotImplementedException();
		}

#pragma warning disable CS0612 // 'DirsI' is obsolete
		public int GetHashCode(DirsI obj)
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{
			return nilnul.objs_.enumerable.Eq<DirI, dir.Eq>.Singleton.GetHashCode(obj);
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
