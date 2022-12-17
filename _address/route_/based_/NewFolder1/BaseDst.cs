using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_
{
	[Obsolete(nameof(route_.based_.Child) )]
	public class BaseDst : RouteI
	{
		private route_.StemI _stem;
		public route_.StemI stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		private _address.DstI _dst;
		public _address.DstI dst
		{
			get { return _dst; }
			set { _dst = value; }
		}


		public BaseDst(StemI stem, DstI dst)
		{
			this._stem = stem;
			this._dst = dst;
		}


		public DivisionI division => _address.div._DstX.Join(

					_stem.div
					,
					dst
		);
		public override string ToString()
		{
			return $"{_stem}{_dst}";
		}
	}
}
