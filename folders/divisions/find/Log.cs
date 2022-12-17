using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders.divisions.find
{
	static public class _LogX_ofPredicate
	{
		static public string _LogSpear(
			IEnumerable<string> shields
			, Predicate<string> predicate
				   , string logKey

		)
		{


			//var logParent =System.IO.Path.GetTempPath();

			//var address4logParent = nilnul.fs.Address.Parse(logParent);
			//address4logParent.tryMakeFileLike();

			//string logAddress;
			//var lognilnul.fs.folder_.temp._CreateLogX.CreateLog("", logAddress);

			//var logPrefix = "findPic";

			//var logAddress = new nilnul.fs.folder.dsts.Ver(address4logParent.ToString()).getNextAddress(logPrefix, "txt");
			string r;
			using (
				var log = nilnul.fs.folder_.tmp._CreateLogX.CreateLog(
					logKey,

					out r

				)//nilnul.fs.File.AppendTxtEnsureFolder(@"c:\temp\a.txt")
			)
			{


				//log.WriteLine(folder.FullName);
				foreach (var division in nilnul.fs.folders._DivisionsX.FsInfoS(
					shields
				))
				{
					if (

						predicate(
							division.FullName
						)

					)
					{

						log.WriteLine(division.FullName);


					}

				}
				log.Flush();
				log.Close();

			}

			return r;
			//Debug.WriteLine(logAddress);
			//Process.Start(logAddress);
		}




		public static string LogSpear(IEnumerable<FolderI> enumerable, Predicate<string> predicate, string logKey)
		{
			return _LogSpear(
				enumerable.Select(x => x.ToString())
				,
				 predicate
				,
				logKey

			);
		}

	}
}
