using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnt
{
	static public class _RegressionsX
	{
		static public _address.Dnt ToOldDnt(DntI dnt) {
			return dnt switch
			{
				Dnt d => new _address.Dnt(d.caption)
				,
				_ => new _address.Dnt(dnt.ToString())
			};
		
		}

		static public _address.Doc ToOldDoc(DntI dnt) {
			return  new _address.Doc(dnt.ToString())
			;
		
		}

		static public DntI ToNew(_address.IDnt dnt) {
			return new Dnt(dnt.ToString());
		
		}



	}
}
