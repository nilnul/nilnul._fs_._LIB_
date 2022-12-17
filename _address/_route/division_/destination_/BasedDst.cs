using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.destination_
{
	static public class _BasedDstX
	{
		static public (string,string) BaseDst(string destination) {
			if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(destination))
			{
				return directory_._BasedDirX.BaseDir(destination);

			}
			return document_._DivDocX.DivDoc(destination);

		}
	}
}
