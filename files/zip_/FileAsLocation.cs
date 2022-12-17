using System.Collections.Generic;

namespace nilnul.fs.files.zip_
{
	public static class FileAsLocationX
	{



		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, nilnul.fs.FileI> locations
			,
			string zipMainName
		)
		{


			return nilnul.fs.locations.zip_.toFile.toTmp._ExtSameX.File_ofAddresses(
				locations
				,
				zipMainName
			);


		}


		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, string> locations
			,
			string zipMainName
		)
		{

			var dict = new Dictionary<
				string
				,
				nilnul.fs.FileI

			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						x.Key

							,
						new nilnul.fs.File(
							x.Value
						)
					);
				}
			);


			return File_ofAddresses(
				dict
				,

				zipMainName
			);




		}

	}
}
