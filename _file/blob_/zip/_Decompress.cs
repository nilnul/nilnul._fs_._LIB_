using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip
{
	[Obsolete("may throw path too long exception if target file path is too long")]
	static public class _DecompressX
	{

		static public void _Void(nilnul.fs.file_.exT_.Zip zip ) {

			var parented = new nilnul.fs.address_.spear_.ParentDoc(zip.ee.file.en);


			var tgtDenote= nilnul.fs.folder.denote_.vered_._NextX.Name(
				parented.parent
				,
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
				nilnul.fs._address.doc._MainX.Main(
					parented.doc
				).ToString())
			);
			#region this will throw Directory not found exception if target subfolder is not found;  also invalid char exception due to incorrect encoding (the default encoding is incorrect; but the explorer extratraction got the encoding right).
			ZipFile.ExtractToDirectory(
				zip.ToString(),
				nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(parented.parent, tgtDenote).ToString()
				,null
				//,Encoding.
			);

			#endregion
			#region still throws exception
			//ZipFile.ExtractToDirectory(
			//	zip.ToString(),
			//	nilnul.fs.address._OverlongX.PrependIfNeed(
			//	nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(parented.parent,tgtDenote).ToString()
			//	)
			//);

			#endregion

			

			nilnul.fs.file.del_._RecyclableX.Del(zip);
		}


		public static void _Void(nilnul.fs.address_.SpearI parentDoc)
		{
			_Void(new fs.file_.exT_.Zip(parentDoc));
		}

		public static void _Void(FileInfo zip)
		{
			_Void( new nilnul.fs.address_.Spear(zip));
		}
		static public void _Void(string rar) {
			_Void(new fs.file_.exT_.Zip(rar));
		}


	}
}
