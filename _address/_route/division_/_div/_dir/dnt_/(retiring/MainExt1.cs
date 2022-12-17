using nilnul.fs._address._dst;
using System;

namespace nilnul.fs._address.doc_
{
	[Obsolete()]
	public class MainExt : DocI
	{
		public const char Seperator = '.';

		private nilnul.fs._address.doc_._exted.Main _main;

		public nilnul.fs._address.doc_._exted.Main main
		{
			get { return _main; }
			set { _main = value; }
		}

		private nilnul.fs._address.doc_._exted.ExtI _ext;

		public nilnul.fs._address.doc_._exted.ExtI ext
		{
			get { return _ext; }
			set { _ext = value; }
		}

		public Denote denote => new Denote(this.ToString());
		public MainExt(nilnul.fs._address.doc_._exted.Main main, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			_MainExtX.Vow(main, ext);
			_main = main;
			_ext = ext;
		}

		public MainExt(nilnul.fs._address.doc_._exted.MainI main, nilnul.fs._address.doc_._exted.ExtI ext):this(new _exted.Main(main),ext)
		{
			
		}


		public MainExt(nilnul.fs._address.doc_._exted.Main main, nilnul.fs._address.doc_._exted.Ext ext) : this(main, (doc_._exted.ExtI)ext)
		{

		}

		public MainExt(nilnul.fs._address.doc_._exted.Main main, string ext) : this(main, new doc_._exted.Ext(ext))
		{

		}

		public MainExt(nilnul.fs._address.doc_._exted.Main main) : this(main, new doc_._exted.Ext())
		{

		}

		public MainExt(string docMain, doc_._exted.ExtI ext) : this(new _exted.Main(docMain), ext)
		{
		}


		public MainExt(string main, nilnul.fs._address.doc_._exted.Ext ext) : this(main, (_exted.ExtI)ext)
		{

		}


		public MainExt(string main, string ext) : this(main, new doc_._exted.Ext(ext))
		{

		}


		static public MainExt OvMain(string main)
		{
			return new MainExt(
				new nilnul.fs._address.doc_._exted.Main(main)
			);
		}



		static public MainExt Parse(string s)
		{
			var lastIndex = s.LastIndexOf(".");
			if (lastIndex == -1)
			{
				lastIndex = s.Length;
			}
			return new MainExt(s.Substring(0, lastIndex), s.Substring(lastIndex));
		}

		static public MainExt Ov(nilnul.fs._address.DocI s)
		{
			return Parse(s.ToString());
		}


		public override string ToString()
		{
			return $"{_main}{_ext}";
		}

	}


}
