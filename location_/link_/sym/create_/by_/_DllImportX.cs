using nilnul.fs.address_;
using nilnul.fs.address_.shield_.based_;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.location_.link_.sym.create_.by_
{
	//[Obsolete()]
	static public class _DllImportX
	{
		const uint SYMBOLIC_LINK_FLAG_FILE = 0x0;
		const uint SYMBOLIC_LINK_FLAG_DIRECTORY = 0x1;
		const uint FOR_UNPREVILIGED = 0x2;


		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
		static extern bool CreateSymbolicLink(
		 string lpSymlinkFileName,
		 string lpTargetFileName,
		 uint dwFlags
		 );




		/// <summary>
		/// if the src's parent is not created yet, an exception is thrown.
		/// </summary>
		/// <param name="link"></param>
		/// <param name="folder"></param>

		public static void _Vod_srcParentAssumeFolder(string link, string folder)
		{
			//

			CreateSymbolicLink(
				link,  // New Link
			   folder,  // tgt
				SYMBOLIC_LINK_FLAG_DIRECTORY | FOR_UNPREVILIGED
			);
		}


		[Obsolete(nameof(_Vod_srcParentAssumeFolder))]
		public static void _Folder(string link, string folder)
		{
			_Vod_srcParentAssumeFolder(link, folder);
		}


		public static void Folder(nilnul.fs.address_.ShieldI parentDir, ShieldI tgt)
		{

			_Folder(parentDir.ToString(), tgt.ToString());
		}


		public static void Folder(nilnul.fs.address_.ShieldI1 parentDir, ShieldI1 tgt)
		{
			_Folder(parentDir.ToString(), tgt.ToString());
		}

		public static void CreateFolder_ofTargetAddress(nilnul.fs.address_.ShieldI link, string target)
		{
			_Folder(link.ToString(), target);
			//throw new NotImplementedException();
		}

		public static void _CreateFolder_srcParentExist_tgtOfPath(nilnul.fs.address_.ShieldI1 child, string tgt)
		{
			_Vod_srcParentAssumeFolder(child.ToString(), tgt);

		}


	}
}
