using System;

namespace nilnul.fs
{
	/// <summary>
	/// with ended slash, address referes to the contained destinations; without ended slahs, address referes to the tagged blob. for nonexistent address, the destination and blob are both null
	/// Contained destinations <see cref=" nameof(nilnul.fs.location._DestinationsX)"/>:
	///		for file, the contained destinations is null.
	///		for folder, the contained destinations is the destinations.
	///		
	///	Tagged Blob <see cref="nameof(nilnul.fs.location._BlobX)"/>:
	///		for folder, the tagged is null
	///		for file, the tagged is blob of the file.
	/// eg:
	/// 	c:\a refers to the tagged object. for file, the tag is the content. for folder, the tag is empty.
	///		c:\a\ refers to the contained destinations. for file, the contained is empty; for folder the contained is the destinations.
	/// </summary>
	public interface IAddress:IPath, path_.IFull
	{

	}
	/// <summary>
	/// this is a txt which denotes a folder or file. The file or folder may be non-existant; it may be set up later.
	/// </summary>
	///
	[Obsolete()]
	public interface AddressI :
		IAddress,

		_address_.VolI, _address_.RouteI
		,nilnul.fs.AnchorI
	{

	}

	///subtype as spear and shield
	///don't conspond spear with file  , shield with folder
	///rather they just conspond with two form of txt: one is ended with "sep", the other is ended with no "sep"
	///later spear can be USED as folder or file; shild can be USED as folder


}
