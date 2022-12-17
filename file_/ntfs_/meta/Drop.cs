using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.ntfs_.meta
{
	static public class _DropX
	{
		// Unblock the file and return true if successful.
		// This method seems to return false if there is
		// a problem rather than throwing an exception.
		static public bool _SuccessUnblocked_assumeFile(string fileName)
		{
			return fs.file._DropX.DeleteFile(fileName + ":Zone.Identifier");
		}
	}
}
