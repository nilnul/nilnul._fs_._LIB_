using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	public class ParentDir:StemI
	{

		private StemI _stem;

		public StemI stem
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

		public DivI div =>  _address.div.co_.Concat.Singleton.op( _stem.div,_dir);

		public DivisionI division => div;

		public ParentDir(StemI stem, DirI1 dir)
		{
			_stem = stem
				;
			_dir = dir;
		}

		static public ParentDir FroDivDir(nilnul.fs._address.DivI div, DirI1 dir) {
			return new ParentDir(
				new stem_.DeckDiv(
					div
				)
				,
				(dir)
			);
		}



		static public ParentDir FroDivDoc(nilnul.fs._address.DivI div, string doc) {
			return FroDivDir(div, nilnul.fs._address.dir_._DocX1.CreateFroDoc(doc));
		}

		static public ParentDir FroStemDoc(nilnul.fs._address.route_.Stem div, string doc) {
			return new ParentDir(
				
					div
				
				,
				dir_._DocX1.CreateFroDoc(doc)
			);
		}

		static public ParentDir FroStemDoc(nilnul.fs._address.route_.StemI div, nilnul.fs._address.DocI doc) {
			return new ParentDir(
				
					div
				
				,
				new Dir1(doc)
			);
		}


		static public ParentDir FroStemDoc(nilnul.fs._address.route_.StemI div, string doc) {
			return FroStemDoc(
				
					div
				
				,
				new Doc(doc)
			);
		}



		

		public override string ToString()
		{
			return $"{_stem}{_dir}";
		}



	}
}
