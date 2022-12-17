using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs.files.dedup_.inSym_
{
	static public class _TraceSrcX
	{
		static public void _Void(
			IEnumerable<nilnul.fs.File> files
			,
			TraceSource log
		)
		{
			file_.nonlinks.dedup_._TraceSrcX._Void(
				files.Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x))
				,
				log
			);

		}

		static public void _Void(
			IEnumerable<string> files
			,
			TraceSource log
		)
		{
			_Void(files.Select(x => new nilnul.fs.File(x)), log);
		}

	}
}

