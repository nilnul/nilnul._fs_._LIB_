using nilnul.fs.address_;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.location_.link_.sym.create_.by_.dllImport_
{
	[Obsolete(nameof(nilnul.fs.folder.dir_.link_.sym._create._DllImportX))]
	static public class _EntryPointWX
	{
		

		[DllImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", CharSet = CharSet.Unicode)]
		public static extern int CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);


	}
}
