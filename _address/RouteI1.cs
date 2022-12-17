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
	public interface RouteI1:IRoute
	{
		_route.DivisionI division { get; }

	}
}
