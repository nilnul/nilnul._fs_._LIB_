using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.based_
{
	public class Child : RouteI1
	{
		private route_.StemI1 _stem;
		public route_.StemI1 stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		private _address._route.division_._div.DstI _dst;
		public _address._route.division_._div.DstI dst
		{
			get { return _dst; }
			set { _dst = value; }
		}


		public Child(StemI1 stem, _address._route.division_._div.DstI dst)
		{
			this._stem = stem;
			this._dst = dst;
		}


		public _address._route. DivisionI division => _address._route.division_.div._ChildX.Join(

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
