using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_.cfg_.nn_.exted_.active
{
	/// <summary>
	/// </summary>
	static public class _EnsureX
	{
	
		static public (string ver, IEnumerable<string> exts) _Ver9exts_addressAssumeFolder(string folder) {

			//var maximal = dst_.cfg_.nn_._ExtedsX.Maximal(folder);
			var active0defaultDst = dst_.cfg_.nn_._ExtedsX._Active0default_addressAssumeFolder(folder);

			if (active0defaultDst.ver is null)
			{
				nilnul.fs.folder.dir._CreateX.Void_ofAddressName(folder, ".nilnul");

				return ("", Enumerable.Empty<string>());
	
			}

			if (active0defaultDst.beDir)
			{
				return (active0defaultDst.ver, active0defaultDst.exts);
			}

			var newVer = $"0{active0defaultDst.ver}";

			nilnul.fs.folder.dir._CreateX.Void_ofAddressName(folder, $".nilnul{newVer}");

			return ( newVer, Enumerable.Empty<string>());
		}

		static public (string ver, IEnumerable<string> exts) Ver9exts(nilnul.fs.FolderI folder) {
			return _Ver9exts_addressAssumeFolder(folder.ToString());
		}
		static public (string ver, IEnumerable<string> exts) Ver9exts(nilnul.fs.FolderI1 folder) {
			return _Ver9exts_addressAssumeFolder(folder.ToString());
		}

	}
}