using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs.address_.shields.divisions.find
{
	static public class _LogX
	{
		static public string LogSpear(
			IEnumerable<ShieldI> shields
			, Regex pattern
			, string logKey
		)
		{
			return nilnul.fs.folders.divisions.find._LogX.LogSpear(
				shields.Select(
					s => nilnul.fs.folder.nulable._ParseX.Ov(s)
				).Where(
					f => f != null
				)
				,
				pattern
				,
				logKey
			);
		}
		static public string LogSpear(
			IEnumerable<ShieldI> shields,
			string pattern,
			string logKey
		)
		{
			return LogSpear(
				shields, new Regex(pattern), logKey
			);
		}

		public static string LogSpear(IEnumerable<AddressI> addresses, string regex, string v)
		{
			return LogSpear(
				addresses.Select(a => nilnul.fs.address_.shield_._AddressX1.Create(a))
				,
				regex
				,
				v
			);
		}

		static public string LogSpear(IEnumerable<string> shields, string pattern, string logKey)
		{
			return nilnul.fs.folders.divisions.find._LogX.LogSpear(
				shields.Select(
					s => nilnul.fs.folder.nulable._ParseX.Parse(s)
				).Where(
					f => f != null
				)
				,
				pattern
				,
				logKey
			);
		}



	}
}