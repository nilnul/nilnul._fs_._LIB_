using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder._cfg_.div.doc_.active
{
	/// <summary>
	/// </summary>
	static public class _VwX
	{

		static public (string ver, IEnumerable<string> exts, bool exists) __Ver9exts_addressAssumeFolder_assumeNub(
			string _addressOfFolder_assumeFolder
			,
			string _nub
		)
		{

			//var maximal = dst_.cfg_.nn_._ExtedsX.Maximal(folder);
			var active0defaultDst = div.dst_._ExtedsX.__Active0default_addressAssumeFolder_assumeNub(
				_addressOfFolder_assumeFolder
				,
				_nub
			);

			if (active0defaultDst.ver is null)
			{
				return ("", Enumerable.Empty<string>(), false);
			}

			if (active0defaultDst.beDir)
			{
				var newVer = $"0{active0defaultDst.ver}";
				return (newVer, Enumerable.Empty<string>(),false);
			}

			return (active0defaultDst.ver, active0defaultDst.exts,true);
		}
		

		/// <summary>
		///  
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="_nub"></param>
		/// <returns></returns>


		static public (string ver, IEnumerable<string> exts, bool exists) _Ver9exts_assumeNub(
			nilnul.fs.FolderI1 folder
			,
			string _nub
		)
		{
			return __Ver9exts_addressAssumeFolder_assumeNub(folder.ToString(), _nub);
		}


		static public (string ver, IEnumerable<string> exts, bool exists) _Ver9exts_assumeNub(
			nilnul.fs.FolderI folder
			,
			string _nub
		)
		{
			return __Ver9exts_addressAssumeFolder_assumeNub(folder.ToString(), _nub);
		}


		static public (string ver, IEnumerable<string> exts,bool exists) _Ver9exts_folderOfAddress_assumeNub(
			string _folder_ofAddress
			,
			string _nub
		)
		{

			return _Ver9exts_assumeNub(
				nilnul.fs.Folder1.FroAddress(_folder_ofAddress)
				,
				_nub
			);


		}




	}
}
