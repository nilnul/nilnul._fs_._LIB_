namespace nilnul.fs.file.be_.exts_
{
	public class XlsxXls : Exts
	{
		public XlsxXls() : base("xls", "xlsx")
		{

		}


		static public XlsxXls Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<XlsxXls>.Instance;
			}
		}



	}
}
