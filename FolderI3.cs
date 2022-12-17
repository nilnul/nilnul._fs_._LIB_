using System;

namespace nilnul.fs
{
	

	/// <summary>
	/// the location of folder that exists on the disk. This is different from the address, which is only a name that references/addresses this physical space.
	/// </summary>
	///
	[Obsolete()]
	public interface FolderI : _folder_.AddressI3, _folder_.BlankI, File0FolderI,IFolder
	{
	}
}
