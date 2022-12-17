using System.IO;

namespace nilnul.fs.file.be_.link_.sym_.by_
{

	static public class _CheckReparseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		/// <remarks>
		/// Just because a file has a reparse point associated with it does NOT mean it's a symbolic link. A reparse point is just an arbitrary set of custom data associated with a file. You need to inspect the ID of the reparse point data to determine if it actually defines a symbolic link. This answer will give false positives anytime it encounters a real file with reparse points. See here: msdn.microsoft.com/en-us/library/windows/desktop/… – Roger Sanders Nov 30 '16 at 22:13 
		///Indeed.Read the last line: msdn.microsoft.com/en-us/library/aa363940.aspx – konsolebox May 10 '17 at 5:36
		///</remarks>
		static public bool _Be(string path)
		{
			FileInfo pathInfo = new FileInfo(path);
			return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);


		}

	}
}
