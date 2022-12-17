using System;

namespace nilnul.fs._address
{

	/// <summary>
	/// decked division
	/// 
	/// "/", "/a", "/a/", "/a/b", "/a/b/"
	/// </summary>
	/// <remarks>
	/// also the tail of "Sproute", indicting that not only root, but the shoot. the root but not vol is included.
	/// </remarks>
	///
	[Obsolete()]
	public interface RouteI:IRoute
	{
		DivisionI division { get; }

	}
}
