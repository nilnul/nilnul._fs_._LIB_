using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.file.duo.route_
{
	public class Rooted:RouteI
	{
		private nilnul.fs._address.sprig_.File _sprig;

		public nilnul.fs._address.sprig_.File sprig
		{
			get { return _sprig; }
			set { _sprig = value; }
		}

		public Rooted(nilnul.fs._address.sprig_.File sprig)
		{
			_sprig = sprig;
		}
		public override string ToString()
		{
			return $"{System.IO.Path.DirectorySeparatorChar}{_sprig}";
		}

	

	

	}
}
