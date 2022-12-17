namespace nilnul.fs
{

	/// <summary>
	/// the location of folder that exists on the disk. This is different from the address, which is only a name that references/addresses this physical space.
	/// </summary>
	public interface FolderI1 : _folder_.AddressI4, _folder_.BlankI, ILocation,IFolder
		,
		File0FolderI
	{
	}
}
