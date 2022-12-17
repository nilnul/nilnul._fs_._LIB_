using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields_.disjoint_
{
	static public class _AddressesX
	{

		static public shields_.Disjoint ToDisjoint(IEnumerable<string> folders)
		{
			return shields_.Disjoint.FroUnsured(folders.Select(x => nilnul.fs.address_.Shield.FroAddress(x)));
		}



	}
}
