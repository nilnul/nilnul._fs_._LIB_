namespace nilnul.fs._address.document.be_.ext_
{
	public class Docx : Ext

	{


		public Docx() : base(doc.be_.ext_.Docx.Singleton)
		{
		}

		static public Docx Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Docx>.Instance;
			}
		}

	}
}
