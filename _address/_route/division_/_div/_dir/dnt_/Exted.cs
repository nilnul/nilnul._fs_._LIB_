using nilnul.fs._address._dst;

namespace nilnul.fs._address._route.division_._div._dir.dnt_
{
	public class Exted : _dir.DntI
	{
		public const char Seperator = '.';

		private nilnul.fs._address._route.division_._div._dir.dnt_._exted.Stub _stub;

		public nilnul.fs._address._route.division_._div._dir.dnt_._exted.Stub stub
		{
			get { return _stub; }
			set { _stub = value; }
		}

		private nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI _ext;

		public _exted.ExtI ext
		{
			get { return _ext; }
			set { _ext = value; }
		}

		public Dnt caption => new Dnt(this.ToString());
		public Exted(_exted.Stub main, dnt_._exted.ExtI ext)
		{
			_ExtedX.Vow(main, ext);
			_stub = main;
			_ext = ext;
		}

		public Exted(dnt_._exted.StubI main, nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI ext):this(new _exted.Stub(main),ext)
		{
			
		}


		public Exted(_exted.Stub main, _exted.Ext ext) : this(main, (dnt_._exted.ExtI)ext)
		{

		}

		public Exted(_exted.Stub main, string ext) : this(main, new dnt_._exted.Ext(ext))
		{

		}

		public Exted(_exted.Stub main) : this(main, new dnt_._exted.Ext())
		{

		}

		public Exted(string docMain, dnt_._exted.ExtI ext) : this(new _exted.Stub(docMain), ext)
		{
		}


		public Exted(string main, _exted.Ext ext) : this(main, (_exted.ExtI)ext)
		{

		}


		public Exted(string main, string ext) : this(main, new dnt_._exted.Ext(ext))
		{

		}


		static public Exted OvStub(string main)
		{
			return new Exted(
				new _exted.Stub(main)
			);
		}



		static public Exted Parse(string s)
		{
			var lastIndex = s.LastIndexOf(".");
			if (lastIndex == -1)
			{
				lastIndex = s.Length;
			}
			return new Exted(s.Substring(0, lastIndex), s.Substring(lastIndex));
		}

		static public Exted Ov(nilnul.fs._address._route.division_._div._dir.DntI s)
		{
			return s switch 
			{
				Exted x=>x
				,
				_=> Parse(s.ToString())
			}	;
		}


		public override string ToString()
		{
			return $"{_stub}{_ext}";
		}

	}


}
