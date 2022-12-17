using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields
{
	static public class _SharedStubX
	{


		static public nilnul.fs.address_.Shield Exe(IEnumerable<ShieldI> shields)
		{
			if (nilnul.seq.be_._NoneX1.Be(shields))
			{
				return null;

			}
			if (nilnul.fs.address_.shields.be_._SameVolSubsetX.Be(shields))
			{

				return new Shield(
					shields.First().vol
					,
					nilnul.fs._address.route_.stems._SharedStubX2.Aggregate(shields.Select(s => s.stem))

				);
			}
			return null;
		}
	}
}
