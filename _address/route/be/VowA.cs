namespace nilnul.fs._address.route.be
{
	public class VowA<T>
		:
#pragma warning disable CS0612 // 'Vow1<RouteI, T>' is obsolete
		nilnul.obj.be.Vow1<RouteI, T>
#pragma warning restore CS0612 // 'Vow1<RouteI, T>' is obsolete
		where T : BeI, new()
	{
	}
}
