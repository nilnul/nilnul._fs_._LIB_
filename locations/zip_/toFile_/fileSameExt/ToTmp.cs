using System.Collections.Generic;

namespace nilnul.fs.locations.zip_.toFile_.fileSameExt
{
	public static class _ToTmpX
	{

		public static nilnul.fs.FileI File_ofNulables(
			nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			> contents
			,
			nilnul.txt_.Vered2 zipFileMainName

		)
		{
			string address = nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(zipFileMainName, ".zip");

			return locations.zip_.toFile_._FileSameExtX.File_ofLocationNulable(contents, address);

		}

		public static nilnul.fs.FileI File_ofAddressNulS(
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

			return File_ofNulables(
				dict
				,
				 txt_.Vered2.Parse(zipMainName)
			);


		}


		public static nilnul.fs.FileI File_ofAddressNulS(
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
						x.Value is null? null:
						nilnul.fs._location_.BlankIX.FroAddress(
							x.Value
						)
					);
				}
			);


			return File_ofAddressNulS(
				dict
				,

				zipMainName
			);



		}

	}
}
