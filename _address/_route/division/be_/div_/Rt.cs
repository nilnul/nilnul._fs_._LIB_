using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.be_.div_
{
	public class Rt : nilnul.fs._address.division.BeI
	{
		
		public bool be(DivisionI obj)
		{
			var divNul = division.ToDivNul.Singleton.to(obj);
			

			return !(divNul is null) && div.be_.Rt.Singleton.be(divNul) ;
		}


		static public Rt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Rt>.Instance;
			}
		}

	}
}
