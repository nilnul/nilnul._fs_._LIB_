using System;

namespace nilnul.fs.folder.destinations.duplicate_
{
	public class Vb
	{
		public static void Duplicate(string sourceParent, string targetParent, bool copySubDirs = true)
		{
			try
			{
				new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(sourceParent, targetParent);

			}
#pragma warning disable CS0168 // The variable 'e' is declared but never used
			catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{


				throw;
			}
		}
	}
}
