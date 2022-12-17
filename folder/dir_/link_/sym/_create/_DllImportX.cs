using nilnul.fs.address_;
using System.Runtime.InteropServices;

namespace nilnul.fs.folder.dir_.link_.sym._create
{
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


		public static void _Vod_srcParentAssumeFolder(string link, string folder)
		{
			//

			CreateSymbolicLink(
				link,  // New Link
			   folder,  // tgt
				SYMBOLIC_LINK_FLAG_DIRECTORY | FOR_UNPREVILIGED
			);
		}
		/// <summary>
		/// it seems this would fail silently if the src's container is not created yet.
		/// </summary>
		/// <param name="lpSymlinkFileName"></param>
		/// <param name="lpTargetFileName"></param>
		/// <param name="dwFlags"></param>
		/// <returns></returns>

		[DllImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", CharSet = CharSet.Unicode)]
		public static extern int CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);


	}
}
