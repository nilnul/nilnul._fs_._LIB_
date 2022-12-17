using System.Collections.Generic;

namespace nilnul.fs._address.div
{
	public class Comp :

		IComparer<nilnul.fs._address.DivI>
	{
		public int Compare(DivI x, DivI y)
		{
			return nilnul.obj.str_.enumable.Comp<DirI, nilnul.fs._address.dir.Comp>.Singleton.Compare(x.dirs, y.dirs);
		}


		static public Comp Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Comp>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Comp>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Comp>' is obsolete: 'Singleton'
			}
		}

	}
}
