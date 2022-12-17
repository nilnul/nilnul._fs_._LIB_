namespace nilnul.fs._address.route_.stem.op_.unary_.join_
{
	public class _DivX
	{
		static public Stem JoinDiv(
			Stem deckedDiv
			,
			nilnul.fs._address.Div div
		)
		{
			return new Stem(
				nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
				deckedDiv.div
				,
				div
				)
			);
		}
	}
}
