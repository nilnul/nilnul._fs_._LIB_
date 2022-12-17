namespace nilnul.fs.address_.spear.be_.exT_
{
	public class Lnk
		: Ext
	{
		public Lnk() : base(".lnk")
		{
		}

		static public Lnk Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lnk>.Instance;
			}
		}

	}
}
