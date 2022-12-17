using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dnts.op_.binary_
{
	static public class _SharedPrefixX
	{
		static public IEnumerable<DocI> Op(IEnumerable<_address.DocI> x, IEnumerable<_address.DocI> y)
		{
			var xEnum = x.GetEnumerator();
			var yEnum = y.GetEnumerator();
			while (xEnum.MoveNext() && yEnum.MoveNext())
			{
				if (
					doc.Eq.Singleton.Equals(xEnum.Current, yEnum.Current)
				)
				{
					yield return xEnum.Current;
				}
				else
				{
					yield break;
				}


			}
			
		}

		public static IEnumerable<Denote> Op(IEnumerable<Denote> x, IEnumerable<Denote> y)
		{

			var xEnum = x.GetEnumerator();
			var yEnum = y.GetEnumerator();
			while (xEnum.MoveNext() && yEnum.MoveNext())
			{
				if (
					doc.Eq.Singleton.Equals(xEnum.Current, yEnum.Current)
				)
				{
					yield return xEnum.Current;
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
