using System;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	public class ParentDiv1 :
		StemA
	//,
	//StemI1
	{

		private StemI _stem;

		public StemI stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DivI _descendent;



		public override DivI div => _address.div.op_.binary_.Concat.Singleton.op(_stem.div, _descendent);


		public ParentDiv1(StemI stem, DivI div)
		{
			_stem = stem
				;
			_descendent = div;
		}

		public ParentDiv1(nilnul.fs._address.DivI div, DivI dir)
		   : this(
				new Stem(
				   div
			   )
			   ,
			   (dir)
				)
		{

		}















		public override string ToString()
		{
			return $"{_stem}{_descendent}";
		}



	}
}
