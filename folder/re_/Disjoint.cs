namespace nilnul.fs.folder.re_
{
	/// <summary>
	/// the two folder don't intersect.
	/// </summary>
	/// <remarks>
	/// cuz folders are from a tree structure, no-intersect means no one is in another.
	/// </remarks>
	static public class _DisjointX
	{
		static public bool Re(nilnul.fs.FolderI a, nilnul.fs.FolderI b)
		{
			return nilnul.fs.address_.shield.re_._DisjointX.Re(
				a.address.en, b.address.en
			);
		}
		static public bool Re(nilnul.fs.Folder a, nilnul.fs.Folder b)
		{
			return nilnul.fs.address_.shield.re_._DisjointX.Re(
				a.en, b.en
			);
		}

	}
}
