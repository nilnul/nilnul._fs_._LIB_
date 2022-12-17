using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.location_.link_
{


	/// <summary>
	/// 	that point to a file or folder on your system
	/// </summary>
	/* Microsoft Windows shortcuts normally refer to a destination by an absolute path (starting from the root directory), whereas POSIX symbolic links can refer to destinations via either an absolute or a relative path. The latter is useful if both the location and destination of the symbolic link share a common path prefix, but that prefix is not yet known when the symbolic link is created (e.g., in an archive file that can be unpacked anywhere).
	Microsoft Windows application shortcuts contain additional metadata that can be associated with the destination, whereas POSIX symbolic links are just strings that will be interpreted as absolute or relative pathnames.

		The function CreateSymbolicLink allows you to create symbolic links using either an absolute or relative path.

Symbolic links can either be absolute or relative links. Absolute links are links that specify each portion of the path name; relative links are determined relative to where relative–link specifiers are in a specified path. Relative links are specified using the following conventions:

Dot (. and ..) conventions—for example, "..\" resolves the path relative to the parent directory.
Names with no slashes (\)—for example, "tmp" resolves the path relative to the current directory.
Root relative—for example, "\Windows\System32" resolves to the "current drive:\Windows\System32". directory
Current working directory-relative—for example, if the current working directory is "C:\Windows\System32", "C:File.txt" resolves to "C:\Windows\System32\File.txt".
Note  If you specify a current working directory–relative link, it is created as an absolute link, due to the way the current working directory is processed based on the user and the thread.

A symbolic link can also contain both junction points and mounted folders as a part of the path name.

Symbolic links can point directly to a remote file or directory using the UNC path.

Relative symbolic links are restricted to a single volume.

Example of an Absolute Symbolic Link
In this example, the original path contains a component, 'x', which is an absolute symbolic link. When 'x' is encountered, the fragment of the original path up to and including 'x' is completely replaced by the path that is pointed to by 'x'. The remainder of the path after 'x' is appended to this new path. This now becomes the modified path.

X: "C:\alpha\beta\absLink\gamma\file"

Link: "absLink" maps to "\\machineB\share"

Modified Path: "\\machineB\share\gamma\file"

Example of a Relative Symbolic Links
In this example, the original path contains a component 'x', which is a relative symbolic link. When 'x' is encountered, 'x' is completely replaced by the new fragment pointed to by 'x'. The remainder of the path after 'x', is appended to the new path. Any dots (..) in this new path replace components that appear before the dots (..). Each set of dots replace the component preceding. If the number of dots (..) exceed the number of components, an error is returned. Otherwise, when all component replacement has finished, the final, modified path remains.

X: C:\alpha\beta\link\gamma\file

Link: "link" maps to "..\..\theta"

Modified Path: "C:\alpha\beta\..\..\theta\gamma\file"

Final Path: "C:\theta\gamma\file"
	*/


	static public class _SymX
	{
		/*This workarround works for me:
Change the return value into an integer. 
1 = success
for all other values call GetLastWin32Error
[DllImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", CharSet = CharSet.Unicode, SetLastError = true)]
static extern int CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SYMBOLIC_LINK_FLAG dwFlags);

public static int CreateSymbolicLinkFix(string lpSymlinkFileName, string lpTargetFileName, int dwFlags) {
    var result = CreateSymbolicLink(lpSymlinkFileName, lpTargetFileName, dwFlags);
    if (result == 1) return 0; // Success
    return Marshal.GetLastWin32Error();
}*/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="lpSymlinkFileName"></param>
		/// <param name="lpTargetFileName"></param>
		/// <param name="dwFlags"></param>
		/// <returns>success or not</returns>
		/// <exception cref=""> if the spear is already occupied</exception>
		/// <remarks>
		/// It is not the case anymore as of Windows 10 Insiders build 14972 (windows 10 creators update).
		/// However, from the comments below the blog post, concerns about the issues mentioned in the other answers are still there, and to make use of this new behaviour, you need to:
		/// enable developer mode on your machine
		/// pass a SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE flag to the CreateSymbolicLink API
		/// 
		/// work for unicode
		/// </remarks>
		[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		//[DllImport("kernel32.dll")]
		static internal extern bool CreateSymbolicLink(
			string lpSymlinkFileName, string lpTargetFileName, _sym.FileOrFolder dwFlags
		);

		/// <summary>
		/// unicode version
		/// </summary>
		/// <param name="lpSymlinkFileName"></param>
		/// <param name="lpTargetFileName"></param>
		/// <param name="dwFlags"></param>
		/// <returns></returns>
		/// <remarks>
		/// enable developer mode:in settings, search developer/开发
		/// </remarks>
		[DllImport("kernel32.dll", SetLastError = true)]
		//[DllImport("kernel32.dll")]
		[Obsolete("not work")]
		static internal extern bool CreateSymbolicLinkW(
			string lpSymlinkFileName, string lpTargetFileName, _sym.FileOrFolder dwFlags
		);




	}
}
