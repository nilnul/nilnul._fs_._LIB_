using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder._cfg_.div.dir_.active
{
	/// <summary>
	/// </summary>
	static public class _EnsureX
	{
	
		static public (string ver, IEnumerable<string> exts) __Ver9exts_addressAssumeFolder_assumeNub(
			string _address_assumeFolder
			,
			string _nub
		) {

			//var maximal = dst_.cfg_.nn_._ExtedsX.Maximal(folder);
			var active0defaultDst = div.dst_._ExtedsX.__Active0default_addressAssumeFolder_assumeNub(
				_address_assumeFolder
				,
				_nub
			);

			if (active0defaultDst.ver is null)
			{
				nilnul.fs.folder.dir._CreateX.Void_ofAddressName(_address_assumeFolder, _nub);
				return ("", Enumerable.Empty<string>());
			}

			if (active0defaultDst.beDir)
			{
				return (active0defaultDst.ver, active0defaultDst.exts);
			}

			var newVer = $"0{active0defaultDst.ver}";

			nilnul.fs.folder.dir._CreateX.Void_ofAddressName(_address_assumeFolder, $"{_nub}{newVer}");

			return ( newVer, Enumerable.Empty<string>());


		}
		static public (string ver, IEnumerable<string> exts) _Ver9exts_assumeNub(
			nilnul.fs.FolderI1 folder
			,
			string _nub
		) {

			return __Ver9exts_addressAssumeFolder_assumeNub(folder.ToString(), _nub);


		}


		static public (string ver, IEnumerable<string> exts) _Ver9exts_folderOfAddress_assumeNub(
			string _folder_ofAddress
			,
			string _nub
		) {

			return _Ver9exts_assumeNub(
				nilnul.fs.Folder1.FroAddress(_folder_ofAddress)
				,
				_nub
			);


		}




	}
}
