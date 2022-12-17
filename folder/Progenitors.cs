using System.Collections.Generic;

namespace nilnul.fs.folder
{
	/// <summary>
	/// self with ancestors.
	/// </summary>
	/// alias:
	///		self0ancestor
	///			one of self0ancestores
	static public class _ProgenitorsX
	{
		/// <summary>
		/// self0ancestor
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			yield return folder;
			foreach (var item in _AncestorsX.Folders(folder))
			{
				yield return item;
			}
		}
	}
}
