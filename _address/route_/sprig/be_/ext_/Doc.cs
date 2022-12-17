namespace nilnul.fs._address.route_.sprig.be_.ext_
{
	public class Doc
		: Ext
	{
		public Doc() : base(_address.document.be_.ext_.Doc.Singleton)
		{
		}

		static public Doc Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Doc>.Instance;
			}
		}

	}
}
