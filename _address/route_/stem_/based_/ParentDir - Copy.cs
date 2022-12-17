using System;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	public class ParentDir :
		StemA,
		StemI
	{

		private StemI _parent;

		public StemI parent
		{
			get { return _parent; }
			set { _parent = value; }
		}
		private DirI _dir;

		public DirI dir
		{
			get { return _dir; }
			set { _dir = value; }
		}

		public override DivI div => _address.div.op_.binary_.Concat.Singleton.op(_parent.div, _dir);


		public ParentDir(StemI stem, DirI dir)
		{
			_parent = stem
				;
			_dir = dir;
		}

		public ParentDir(nilnul.fs._address.DivI div, DirI dir)
		   : this(
				new Stem(
				   div
			   )
			   ,
			   (dir)
				)
		{

		}

		public ParentDir(nilnul.fs._address.DivI div, DocI dir)
		   : this(
				new Stem(
				   div
			   )
			   ,
			   (dir)
				)
		{
		}
		public ParentDir(nilnul.fs._address.route_.StemI div, nilnul.fs._address.DocI doc)
			: this(div, new nilnul.fs._address.Dir(doc))
		{

		}

		public override string ToString()
		{
			return $"{_parent}{_dir}";
		}
	}
}
