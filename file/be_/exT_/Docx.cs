namespace nilnul.fs.file.be_.ext_
{
	public class Docx : Ext
	{
		public Docx() : base(address_.spear.be_.ext_.Docx.Singleton)
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
