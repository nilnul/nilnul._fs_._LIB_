using System.Diagnostics;
using System.IO;

namespace nilnul.fs.folder
{
	/// <summary>
	/// by process.start
	/// <see cref="nameof(explore_._ByExeSelfX)"/>
	/// </summary>
	static public class _ExploreX
	{
		public static void _Explore(string folder)
		{
			Process.Start("explorer.exe", folder);

		}


		public static void Explore(nilnul.fs.FolderI createdTarget)
		{
			_Explore(createdTarget.ToString());
		}
		public static void Explore(nilnul.fs.Folder createdTarget)
		{
			Explore((nilnul.fs.FolderI)createdTarget);
		}

		public static void Explore(nilnul.fs.address_.ShieldI createdTarget)
		{
			Explore(new nilnul.fs.Folder(createdTarget));
		}

		public static void Explore(DirectoryInfo createdTarget)
		{
			Explore(new nilnul.fs.Folder(createdTarget));
		}





	}
}
