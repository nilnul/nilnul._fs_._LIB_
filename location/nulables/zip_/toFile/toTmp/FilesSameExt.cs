using System.Collections.Generic;

namespace nilnul.fs.location.nulables.zip_.toFile.toTmp
{
	public static class _ExtSameX
	{

		//	public static nilnul.fs.FileI1 File(
		//	nilnul.obj.Dict<
		//		nilnul.fs._address._dst.denote.str_.seq.Join
		//		,
		//		nilnul.fs.FileI1
		//		,
		//		nilnul.fs._address._dst.denote.str_.seq.Eq
		//	> contents
		//	,
		//	nilnul.txt_._vered_.Name zipFileMainName

		//)
		//	{
		//		var dict = new nilnul.obj.Dict<
		//			nilnul.fs._address._dst.denote.str_.seq.Join
		//			,
		//			nilnul.fs._location_.BlankI
		//			,
		//			nilnul.fs._address._dst.denote.str_.seq.Eq
		//		>();

		//		contents.ForEach(
		//			x =>
		//			{
		//				dict.Add(
		//					(x.Key)

		//						,
		//						x.Value
		//					);
		//			}
		//		);

		//		return locations.zip_.toFile._ToTmpX.File(dict, zipFileMainName);

		//	}
		public static nilnul.fs.FileI File(
			Dictionary<string, nilnul.fs._location_.BlankI> locations
			,
			nilnul.txt_._vered.Name zipFileMainName
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
						nilnul.fs.location.nulable.be_.File.Singleton.be(x.Value) ?
							x.Key + nilnul.fs.address_.spear._DocExtX.Ext(x.Value.ToString())
							:
							x.Key
							,
							x.Value
						);
				}
			);

			return _ToTmpX.File(
				dict
				,
				zipFileMainName
			);
		}

		public static nilnul.fs.FileI File(
			Dictionary<string, nilnul.fs._location_.BlankI> locations
			,
			string zipMainName
		)
		{

			return File(
				locations
				,
				new txt_._vered.Name(zipMainName)
			);


		}

		/// <summary>
		/// of files
		/// </summary>
		/// <param name="locations"></param>
		/// <param name="zipMainName"></param>
		/// <returns></returns>
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
						 nilnul.fs.location_.file0Folder.nulable._ParseX.Parse(
							x.Value
						)
					);
				}
			);


			return File(
				dict
				,

				zipMainName
			);
		}

		public static nilnul.fs.FileI File_keyMaybeRoute_ofAddresses(
			Dictionary<string, string> locations
			,
			string zipFile
		)
		{
			var dict = new Dictionary<
				string
				,
				string

			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						nilnul.txt.op_.unary_.fs_.StripBeginSep.Singleton.op(x.Key)

							,
						x.Value
					);
				}
			);
			return File_ofAddresses(dict, (zipFile));
		}
	}
}
