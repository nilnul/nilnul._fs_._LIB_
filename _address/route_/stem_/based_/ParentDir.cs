namespace nilnul.fs._address.route_.stem_
{
	public class ParentDir1 :
		StemA1,
		StemI1
	{

		private StemI1 _parent;

		public StemI1 parent
		{
			get { return _parent; }
			set { _parent = value; }
		}
		private _route.division_._div. DirI _dir;

		public _route.division_._div.DirI dir
		{
			get { return _dir; }
			set { _dir = value; }
		}

		public override _route.division_.DivI div => _address._route.division_.div.op_.binary_.Concat.Singleton.op(_parent.div, _dir);


		public ParentDir1(StemI1 stem, _route.division_._div.DirI dir)
		{
			_parent = stem
				;
			_dir = dir;
		}

		public ParentDir1(nilnul.fs._address._route.division_.DivI div, _route.division_._div.DirI dir)
		   : this(
				new Stem1(
				   div
			   )
			   ,
			   (dir)
				)
		{

		}

		public ParentDir1(
			nilnul.fs._address._route.division_.DivI div
			,
			_route.division_._div._dir.DntI dir
		)
		 : this(
			div, new nilnul.fs._address._route.division_._div.Dir(dir)
		)
		{

		}

		public override string ToString()
		{
			return $"{_parent}{_dir}";
		}
	}
}
