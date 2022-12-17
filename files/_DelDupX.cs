using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.files
{
	static public class _DelDupX
	{

		static public void _Void(
			IEnumerable<nilnul.fs.File> files
			,
			StreamWriter log
		)
		{
			file_.nonlinks._DelDupX._Void(
				files.Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x))
				,
				log
			);

		}

		static public void _Void(
			IEnumerable<string> files
			,
			StreamWriter log
		)
		{
			_Void(files.Select(x => new nilnul.fs.File(x)), log);
		}
	}
}

