namespace nilnul.fs._address.doc_.exted
{
	static public class _MainX
	{
		public static doc_._exted.Main Main(DocI obj)
		{
			return nilnul.fs._address.doc_.MainExt.Ov(obj).main;

		}

		static public doc_._exted.Main _Main(string _doc)
		{
			return Main(
				new nilnul.fs._address.Doc(_doc)
			);
		}

	}
}
