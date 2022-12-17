using System;

namespace nilnul.fs._folder_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// ...\   is shield
	/// ....\abc is spear
	/// </remarks>
	///
	[Obsolete()]
	public interface AddressI<T>
		where T : nilnul.fs.address_.ShieldI
	{
		nilnul.fs.address_.shield_._exist_.Shield<T> address { get; }

	}
}
