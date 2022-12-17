using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nilnul.blob_.zip.of_.locationNulS
{
		public static class _ToTmpX
		{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="contents"></param>
		/// <param name="zipFileMainName">append sub if need</param>
		/// <returns></returns>
			public static nilnul.fs.FileI File_ofNulables(
				nilnul.obj.Dict<
					nilnul.fs._address._dst.denote.str_.seq.Join
					,
					nilnul.fs._location_.BlankI
					,
					nilnul.fs._address._dst.denote.str_.seq.Eq
				> contents
				,
				//nilnul.txt_.Vered2
				string zipFileMainName

			)
			{
				string address = nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next.OvAddress(System.IO.Path.GetTempPath()).address(zipFileMainName, ".zip");

				return of_.LocationNulS.File_ofLocationNulable(contents, address);

			}

			public static nilnul.fs.FileI File_ofAddressNulS(
				Dictionary<string, nilnul.fs._location_.BlankI> locations
				,
				string zipMainName
			)
			{
				obj.Dict<fs._address._dst.denote.str_.seq.Join, fs._location_.BlankI, fs._address._dst.denote.str_.seq.Eq> dict = new nilnul.obj.Dict<
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
							new nilnul.fs._address._dst.denote.str_.seq.Join(
							nilnul.fs._address.Division0RouteX.GetDivision(
							x.Key
							)
						)

								,
								x.Value
							);
					}
				);

				return File_ofNulables(
					dict
					,
					 /*nilnul.txt_.Vered2.Parse*/(zipMainName)
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
							x.Value is null ? null :
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
