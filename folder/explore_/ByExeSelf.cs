using System.Diagnostics;
using System.IO;

namespace nilnul.fs.folder.explore_
{
	/// <summary>
	/// if ends with "/", not work
	/// </summary>
	static public class _ByExeSelfX
	{
		public static void OfShield(string folder)
		{
			Process.Start(folder, folder);
		}

		public static void OfAddress(string folder)
		{
			OfShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(folder)
			);
		}

		public static void Exe(nilnul.fs.address_.ShieldI folder)
		{
			OfShield(folder.ToString());
		}

		public static void Exe(DirectoryInfo createdTarget)
		{
			OfAddress(createdTarget.FullName);
		}

		public static void Exe(nilnul.fs.FolderI createdTarget)
		{
			OfAddress(createdTarget.ToString());
		}
		public static void Exe(nilnul.fs.Folder createdTarget)
		{
			Exe((FolderI)createdTarget);
		}

	}
}