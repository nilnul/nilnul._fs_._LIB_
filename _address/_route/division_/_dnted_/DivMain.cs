namespace nilnul.fs._address
{
	public class DivMain
	{
		private DivI _div;

		public DivI div
		{
			get { return _div; }
			set { _div = value; }
		}

		private doc_._exted.Main _main;

		public doc_._exted.Main main
		{
			get { return _main; }
			set { _main = value; }
		}

		public DivMain(DivI div, doc_._exted.Main main)
		{
			_div = div;
			_main = main;
		}

		public DivMain(doc_._exted.Main main) : this(new _address.Div(), main)
		{

		}

		public DivMain(string v1, string v2) : this(
			nilnul.fs._address.Div.Parse(v1)
			,
			new nilnul.fs._address.doc_._exted.Main(v2)
		)
		{
		}

		public DocumentI genDocument(doc_._exted.ExtI ext)
		{
			return new nilnul.fs._address.Document(
				_div,
				new nilnul.fs._address.doc_.MainExt(_main, ext)
			);
		}


		public override string ToString()
		{
			return $@"{_div}{main}";
		}

		static public DivMain Parse(string s)
		{
			var lastIndex = s.LastIndexOfAny(
				nilnul.fs._address._route_._SeparatorX.Chars
			);

			if (lastIndex == -1)
			{
				return new DivMain(new nilnul.fs._address.doc_._exted.Main(s));
			}

			return new DivMain(
				s.Substring(0, lastIndex + 1)
				,
				s.Substring(lastIndex + 1)
			);



		}
	}
}
