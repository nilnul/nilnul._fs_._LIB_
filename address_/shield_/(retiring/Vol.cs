using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	public class Vol : 
		nilnul.obj.Box<nilnul.fs._address.VolI>
		,
		
		ShieldI
	{
		public Vol(VolI val) : base(val)
		{
		}

		public StemI1 stem => new nilnul.fs._address.route_.Stem1();

		public VolI vol => boxed;

		public RouteI route => stem;
	}
}
