namespace nilnul.fs._folder_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// ...\   is shield
	/// ....\abc is spear
	/// </remarks>
	public interface AddressI1<T>
		where T : nilnul.fs.address_.ShieldI1
	{
		nilnul.fs.address_.shield_.Exist<T> address { get; }

	}
}
