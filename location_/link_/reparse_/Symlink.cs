using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_.reparse_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// symbolic link: A symbolic link is a reparse point that points to another file system object. The object being pointed to is called the target. Symbolic links are transparent to users; the links appear as normal files or directories, and can be acted upon by the user or application in exactly the same manner. Symbolic links can be created using the FSCTL_SET_REPARSE_POINT request as specified in [MS-FSCC] section 2.3.61. They can be deleted using the FSCTL_DELETE_REPARSE_POINT request as specified in [MS-FSCC] section 2.3.5. Implementing symbolic links is optional for a file system.
	/// In a similar manner, you can determine if a reparse point is a symbolic link by testing whether the tag value is IO_REPARSE_TAG_SYMLINK.
	/// </remarks>
	/// 
	public interface SymlinkI {

	}
	class Symlink
	{
	}
}
