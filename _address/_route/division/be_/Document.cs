namespace nilnul.fs._address.division.be_
{
	public class Document : BeI
	{
		public bool be(DivisionI obj)
		{
			return !Div.Singleton.be(obj);
		}

		static public Document Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Document>.Instance;
			}
		}

	}
}
