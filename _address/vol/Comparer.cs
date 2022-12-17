using System.Collections.Generic;

namespace nilnul.fs._address.vol
{
	public interface ComparerI : IComparer<VolI>
	{

	}

	public class Comparer : ComparerI
	{
		public int Compare(VolI x, VolI y)
		{
			return nilnul.txt.comp_.CaseInsentive.Singleton.Compare(x.name, y.name);
			//throw new NotImplementedException();
		}


		static public Comparer Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Comparer>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Comparer>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Comparer>' is obsolete: 'Singleton'
			}
		}

	}
}
