using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_
{
	
	[Obsolete()]
	public abstract class SpearA : SpearI
	{
		public abstract SprigI1 sprig { get; }
		public abstract VolI vol { get; }
		public  RouteI route { get { return sprig; } }
	}
}
