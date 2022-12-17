namespace nilnul.fs.address_.shield_.nonRt.cast_
{
	static public class _SpearX
	{
		static public nilnul.fs.address_.SpearI Spear(NonRtI nonRt)
		{
			return new nilnul.fs.address_.Spear(
				nonRt.vol
				,
				fs._address.route_.stem_.noRt.cast_._SprigX.Sprig(
					nonRt.stem
				)
			);
		}
		static public nilnul.fs.address_.SpearI Spear(ShieldI nonRt)
		{
			return Spear(new nilnul.fs.address_.shield_.NonRt(nonRt));
		}

	}
}
