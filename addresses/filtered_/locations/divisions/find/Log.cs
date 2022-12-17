using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.addresses.filtered_.locations.divisions.find
{
	static public class _LogX
	{
		static public string _LogSpear(
			IEnumerable<AddressI> addresses
			, Predicate<File0FolderI> predicate
		, string key = "found"
		)
		{
			string r;
			using (
				var log = nilnul.fs.folder_.tmp._CreateLogX.CreateLog(
					key,

					out r

				)//nilnul.fs.File.AppendTxtEnsureFolder(@"c:\temp\a.txt")
			)
			{

				divisions._FindX._Locations(addresses, predicate).ForEach(
					x =>
						log.WriteLine(x.ToString())
				);

				log.Flush();
				log.Close();
			}
			return r;
		}

		static public string _LogSpear(
			IEnumerable<string> shields
			, Predicate<File0FolderI> predicate
			, string key = "found"
		)
		{
			return _LogSpear(
				shields.Select(x => nilnul.fs.AddressA.Parse(x))
				, predicate
				, key
			);
		}
	}
}
