using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._route.division_.denotation_
{
	static public class _DivDenotationX
	{
		static public _route.division_.div.Dnted Splice(_route.division_. DivI div, _route.division_.div.DntedI division)
		{
			return new _route.division_.div.Dnted(
				_address._route.division_.div.op_.binary_.Concat.Singleton.op(div,division.div)
				,
				division.dnt
			);
		}

		public static _route.division_.div.Dnted Splice(_route.division_._div. DirI dir, _route.division_.div.Dnted document)
		{
			return Splice(
				 new _address._route.division_.Div(dir)
				 ,
				 (_route.division_.div.DntedI)document

			)
			;
		}

		public static _route.division_.div.DntedI Splice(_route.division_._div.DirI dir, _route.division_.div.DntedI document)
		{

			return Splice(
				 new _address._route.division_.Div(dir)
				 ,
				 document

			)
			;


		}

	



	}
}
