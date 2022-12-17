namespace nilnul.fs
{
	
	/// <summary>
	/// this is a txt which denotes a folder or file. The file or folder may be non-existant; it may be set up later.
	/// </summary>
	public interface AddressI1 :
		IAddress
		,

		_address_.VolI, _address_.RouteI1
		
	{

	}

	///subtype as spear and shield
	///don't conspond spear with file  , shield with folder
	///rather they just conspond with two form of txt: one is ended with "sep", the other is ended with no "sep"
	///later spear can be USED as folder or file; shild can be USED as folder


}
