namespace nilnul.fs._address.doc_._exted.ext_.ovAftDot_
{
	public class Pdf : OvAftDot
	{

		public const string TXT = "PDF";
		public Pdf() : base(TXT)
		{

		}

		static public Pdf Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Pdf>.Instance;
			}
		}

	}
}
