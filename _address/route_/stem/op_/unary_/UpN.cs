namespace nilnul.fs._address.route_.stem.op_.unary_
{
	public class UpN : UnaryI
	{

		static public Stem _Op(
			StemI arg
			,
			uint n
		)
		{
			return new Stem(
							 nilnul.fs._address.container.div.convert_.UpN._Eval(

								arg.div
								, n
							)
						);

		}

		static public Stem _Op(
			Stem arg
			,
			uint n
		)
		{
			return _Op((StemI)arg,n);

		}

		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}

		public UpN(uint n)
		{
			_n = n;
		}

		public StemI op(StemI arg)
		{
			return new Stem(
				new nilnul.fs._address.container.div.convert_.UpN(_n).eval(

					arg.div
				)
			);


			//throw new NotImplementedException();
		}



	}
}
