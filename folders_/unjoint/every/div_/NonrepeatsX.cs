using System.Collections.Generic;
using System.IO;

namespace nilnul.fs.folders_.unjoint.every.div_
{
	static public class NonrepeatsX
		{
			static public IEnumerable<string> Addresses(

				_nonrepeats.Io io
			)
			{


				return new Nonrepeats(io).addresses();



			}

			static public IEnumerable<string> Addresses(
				IEnumerable<string> foldersIsolated

			)
			{
				///add actual trees.
				///

				return Addresses(

					 _nonrepeats.Io.OfAddresses_removeNonfolder(
					foldersIsolated
				));
			}
			static public IEnumerable<string> Addresses(
				params string[] foldersIsolated

			)
			{
				///add actual trees.
				///

				return Addresses(

					(IEnumerable<string>)foldersIsolated
				);
			}


			public static IEnumerable<string> Addresses(
				IEnumerable<string> folders
				,
				StreamWriter log
			)
			{
				return Addresses(

					 _nonrepeats.Io.OfAddresses_removeNonfolder(
					folders, log
				));


			}
		}

}
