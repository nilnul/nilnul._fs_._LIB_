using System.Collections.Generic;

namespace nilnul.fs.address_.shield
{
	public interface CompI : IComparer<nilnul.fs.address_.ShieldI>
	{

	}

	public class Comp : CompI
	{
		public int Compare(ShieldI x, ShieldI y)
		{
			var valCompared = nilnul.fs._address.vol.Comparer.Singleton.Compare(x.vol, y.vol);

			return valCompared == 0 ? nilnul.fs._address.route_.stem.Comp.Singleton.Compare(x.stem, y.stem) : 0;
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
