using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields_.disjoint_
{
	[Obsolete()]
	static public class _AddressesX 
	{

		static public shields_.Disjoint Disjoint(IEnumerable<string> folders)
		{
			return shields_.Disjoint.Fro(folders.Select(x => nilnul.fs.address_.Shield.FroAddress(x)));
		}
	
	}
}
