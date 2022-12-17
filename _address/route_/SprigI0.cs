using System;

namespace nilnul.fs._address.route_
{
	/// <summary>
	/// there is an separator at the end. sprig. not stem
	/// </summary>
	///
	[Obsolete()]
	public interface SprigI : RouteI
	{
		_address.DocumentI document
		{
			get;
		}
	}
}