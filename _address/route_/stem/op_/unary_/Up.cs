namespace nilnul.fs._address.route_.stem.op_.unary_
{
	public class Up : UnaryI
	{
		public StemI op(StemI arg)
		{
			return new Stem(
				nilnul.fs._address.container.div.convert_.Up.Singleton.eval(

					arg.div
				)
			);


			//throw new NotImplementedException();
		}



		static public Up Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Up>.Instance;
			}
		}

	}
}
