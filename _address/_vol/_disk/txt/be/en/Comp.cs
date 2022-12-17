using System.Collections.Generic;

namespace nilnul.fs._address._vol_._name.txt.be.en
{
	public class Comp : IComparer<En>
	{
		public int Compare(En x, En y)
		{
			return nilnul.txt.comp_.CaseInsentive.Singleton.Compare(x.en, y.en);
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
