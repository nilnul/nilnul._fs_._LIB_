using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder._cfg_
{
	static public class _DntX
	{
		public static string _Dnt_assumeNub_assumeExts(
			string nub, (string ver, IEnumerable<string> exts) ver9exts
		) {
			return $@"{nub}{ver9exts.ver}{string.Join("",ver9exts.exts)}";
		}
		public static string _Dnt_assumeNub_assumeExts(
			string nub, string ver, IEnumerable<string> exts 
		) {
			return $@"{nub}{ver}{string.Join("",exts)}";
		}


	}
}
