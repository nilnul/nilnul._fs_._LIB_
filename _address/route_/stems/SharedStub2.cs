using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.route_.stems
{
	static public class _SharedStubX2
	{
		static public route_.Stem Aggregate(IEnumerable<route_.StemI> x)
		{

			if (x.Any())
			{
				return stem.op_.binary_._SharedStubX.Co(
					x.First()
					,
					Aggregate(x.Skip(1))
				);
			}
			else
			{
				return new Stem();
			}

		}

	}
}
