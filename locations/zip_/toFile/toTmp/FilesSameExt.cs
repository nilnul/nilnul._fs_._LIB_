using System.Collections.Generic;

namespace nilnul.fs.locations.zip_.toFile.toTmp
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

		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, nilnul.fs.FileI> locations
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
						x.Key + nilnul.fs.file._ExtX.Ext(x.Value)

							,
							x.Value
						);
				}
			);

			return _ToTmpX.File_ofAddresses(
				dict
				,
				zipMainName
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
