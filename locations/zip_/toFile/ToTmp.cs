using System.Collections.Generic;

namespace nilnul.fs.locations.zip_.toFile
{
	public static class _ToTmpX
	{

		public static nilnul.fs.FileI File(
			nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			> contents
			,
			nilnul.txt_._vered_.Name zipFileMainName

		)
		{
			string address = nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(zipFileMainName, ".zip");

			return locations.zip_._ToFileX.File(contents, address);

		}

		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, nilnul.fs._location_.BlankI> locations
			,
			string zipMainName
		)
		{
			obj.Dict<_address._dst.denote.str_.seq.Join, _location_.BlankI, _address._dst.denote.str_.seq.Eq> dict = new nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						nilnul.fs._address._dst.denote.str_.seq.Join.Parse(x.Key)

							,
							x.Value
						);
				}
			);

			return File(
				dict
				,
				new txt_._vered_.Name(zipMainName)
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
				nilnul.fs._location_.BlankI

			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						x.Key

							,
						nilnul.fs._location_.BlankIX.FroAddress(
							x.Value
						)
					);
				}
			);


			return File_ofAddresses(
				dict
				,

				nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(zipMainName, ".zip")
			);



		}

	}
}
