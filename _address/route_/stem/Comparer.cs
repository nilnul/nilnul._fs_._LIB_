using System.Collections.Generic;

namespace nilnul.fs._address.route_.stem
{

	public class Comp : IComparer<StemI>
	{
		public int Compare(StemI x, StemI y)
		{
			return nilnul.fs._address.div.Comp.Singleton.Compare(x.div, y.div);
			//throw new NotImplementedException();
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
