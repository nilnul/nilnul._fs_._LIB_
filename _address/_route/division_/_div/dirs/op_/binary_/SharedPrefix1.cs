using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dirs.op_.binary_
{
	static public class _SharedPrefixX
	{
		static public IEnumerable<DirI> Op(IEnumerable<DirI> x, IEnumerable<DirI> y)
		{
			for (int i = 0; i < nilnul.num.integer.co_._MinX.Co(x.Count(), y.Count()); i++)
			{
				if (dir.Eq.Singleton.Equals(x.ElementAt(i), y.ElementAt(i)))
				{
					yield return x.ElementAt(i);
				}
				else
				{
					yield break;
				}

			}
		}

		//static public IEnumerable<DirI> To(DirsI x, DirsI y) {
		//	return To(x as IEnumerable<DirI>, y as IEnumerable<DirI>);
		//}
		//static public IEnumerable<DirI> To(Dirs x, Dirs y) {
		//	return To(x as DirsI, y as DirsI);
		//}


	}
}
