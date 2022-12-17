using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_
{
	/// <summary>
	/// </summary>
	static public class _ReparseX
	{
		/*private bool IsSymbolic(string path)
{
    FileInfo pathInfo = new FileInfo(path);
    return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
}
shareimprove this answer
edited Jun 29 '15 at 17:44

Unknown6656
1,13621231
answered Oct 20 '14 at 20:04

zurfyx
9,83875584
2
This should be the accepted answer. It's simple, concise, and directly answers the question. – Jim Gomes Mar 30 '16 at 22:23
Is there something I am missing about this solution vs the accepted solution because this seems a lot nicer. – Max Young Oct 11 '16 at 17:29
6
Just because a file has a reparse point associated with it does NOT mean it's a symbolic link. A reparse point is just an arbitrary set of custom data associated with a file. You need to inspect the ID of the reparse point data to determine if it actually defines a symbolic link. This answer will give false positives anytime it encounters a real file with reparse points. See here: msdn.microsoft.com/en-us/library/windows/desktop/… – Roger Sanders Nov 30 '16 at 22:13 
Indeed. Read the last line: msdn.microsoft.com/en-us/library/aa363940.aspx – konsolebox May 10 '17 at 5:36*/
		public static bool Be(string path)
		{
			return Be(new FileInfo(path));
		}

		public static bool Be(FileInfo pathInfo)
		{
			return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
		}


	}
}
