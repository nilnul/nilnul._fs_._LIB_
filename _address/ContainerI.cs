namespace nilnul.fs._address
{
	/// <summary>
	/// for a folder. the address must end with "\" or "/".
	/// such as :
	///		c:\
	///		c:\a\
	///		c:\a\b\
	///	not:
	///		c:
	///		c:\a
	///		c:\a\b
	///		\
	///		""
	///		,\a
	///		a
	///		,\a\
	///		,\a\b
	/// </summary>
	/// 

	interface ContainerI
	{
	}
}
