using System;

namespace nilnul.fs._address.route_
{
	/// <summary>
	/// there is an separator at the end and the begining. including:
	///  "/", the deck base.
	/// </summary>
	///
	[Obsolete()]
	public interface StemI
		: RouteI
	{
		_address.DivI div
		{
			get;
		}
	}
}