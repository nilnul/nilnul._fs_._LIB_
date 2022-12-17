using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.directory_
{
	[Obsolete()]
	static public class _DirDivX
	{
		

		static public Directory Directory( _address.DirI dir, _address.DivI div ) {
			return new Directory(
				new[] { dir }.Concat( div.dirs)
			);
		}
	}
}
