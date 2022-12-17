namespace nilnul.fs._address._route.division_.div_
{
	public interface IDirectory
		:IDestination,
		IDiv
	{

	}
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	public interface DirectoryI : DestinationI, DivI, IDirectory
	{



	}

}
