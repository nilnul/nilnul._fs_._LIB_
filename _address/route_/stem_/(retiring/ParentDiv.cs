using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	public class ParentDiv:
		StemA,
		StemI1
	{

		private StemI1 _stem;

		public StemI1 stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DivI1 _descendent;

		

		public override DivI1 div =>  _address.div.co_.Concat1.Singleton.op( _stem.div,_descendent);


		public ParentDiv(StemI1 stem, DivI1 div)
		{
			_stem = stem
				;
			_descendent = div;
		}

		 public ParentDiv(nilnul.fs._address.DivI1 div, DivI1 dir)
			:this(
				 new  Stem1(
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
