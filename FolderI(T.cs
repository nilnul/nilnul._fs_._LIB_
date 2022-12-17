using System;

namespace nilnul.fs
{
	/// <summary>
	/// </summary>
	///
	[Obsolete()]
	public interface FolderI<T> :
		nilnul.fs._folder_.AddressI<T>
		where T : nilnul.fs.address_.ShieldI
	{

	}
}
