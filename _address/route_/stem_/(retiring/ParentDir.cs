using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	public class ParentDir1:
		StemA,
		StemI1
	{

		private StemI1 _stem;

		public StemI1 stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DirI1 _dir;

		public DirI1 dir
		{
			get { return _dir; }
			set { _dir = value; }
		}

		public override DivI1 div =>  _address.div.co_.Concat1.Singleton.op( _stem.div,_dir);


		public ParentDir1(StemI1 stem, DirI1 dir)
		{
			_stem = stem
				;
			_dir = dir;
		}

		 public ParentDir1(nilnul.fs._address.DivI1 div, DirI1 dir)
			:this(
				 new  Stem1(
					div
				)
				,
				(dir)
				 )
		{
			
		}

		 public ParentDir1(nilnul.fs._address.DivI1 div, DocI dir)
			:this(
				 new  Stem1(
					div
				)
				,
				(dir)
				 )
		{
			
		}



		

		public ParentDir1(nilnul.fs._address.route_.StemI1 div, nilnul.fs._address.DocI doc)
			:this(div, new nilnul.fs._address.Dir1(doc))

		{
			
		}


		



		

		public override string ToString()
		{
			return $"{_stem}{_dir}";
		}



	}
}
