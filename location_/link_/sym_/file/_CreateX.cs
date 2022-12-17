using nilnul.fs.address_;
using nilnul.fs.address_.spear_;

namespace nilnul.fs.location_.link_.sym_.file
{


	/// <summary>
	/// 	that point to a file or folder on your system
	/// </summary>

	static public class _CreateX
	{
		/// <summary>
		/// if the link exist, it's overwritten?
		/// </summary>
		/// <param name="lpSymlinkFileName"></param>
		/// <param name="lpTargetFileName"></param>
		/// <returns></returns>
		static public bool Succeed(
			string lpSymlinkFileName, string lpTargetFileName
		)
		{
			return link_._SymX.CreateSymbolicLink(
				lpSymlinkFileName
				, lpTargetFileName
				, 
				//(int)
				(_sym.FileOrFolder.File | _sym.FileOrFolder.SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE)
			);
		}

		public static bool Succeed(ParentDocument parentDocument, SpearI value)
		{
			return Succeed(
				parentDocument.ToString(), value.ToString()
			);
		}
	}
}
