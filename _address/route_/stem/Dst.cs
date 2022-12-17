namespace nilnul.fs._address.route_.stem
{
	public class _DstX
	{
		//static public StemI Join(
		//	StemI deckedDiv
		//	,
		//	nilnul.fs._address.DstA dst
		//)
		//{
		//	return new Stem(
		//		nilnul.fs._address.container.div.convert_.join_._DirX.Eval(
		//			deckedDiv.div
		//			,
		//			dst
		//		)
		//	);
		//}

		static public RouteI Join(
			StemI deckedDiv
			,
			nilnul.fs._address.DstI dst
		)
		{
			return RouteA.Ov( _address.div._DstX.Join(
				
					deckedDiv.div
					,
					dst
				)
			);
		}

	}
}
