using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path.dst
{
	static public class _AppendX
	{
		static public nilnul.fs._address_.Path Append(nilnul.fs._address_.Path path, nilnul.fs._address_._path.Dst dst) {
				return new Path(
						path.toFolderLike().stem
						,
						new _path_.Tip(
							dst
						)
					
				);

		}
	}
}
