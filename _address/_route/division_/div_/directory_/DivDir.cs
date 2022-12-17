using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.directory_
{
	static public class _BasedDirX
	{
		static public (string,string) BaseDir(string directory) {


			var r=document_._DivDocX.DivDoc(
				_address. directory._toDocument._TxtX.ToDocument(directory)
			);
			return (r.Item1, _address.dir._froDoc._TxtX.AppendSep(r.Item2));
		}

		static public Directory Directory(_address.DivI div, _address.DirI dir ) {
			return new Directory(
				div.dirs.Concat(new[] { dir })
			);
		}
	}
}
