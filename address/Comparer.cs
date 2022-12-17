using System;
using System.Collections.Generic;

namespace nilnul.fs.address
{
	public class Comparer : IComparer<nilnul.fs.AddressI>
	{

		static public nilnul.obj.tuple_.bi.Comparer<nilnul.fs._address.VolI, nilnul.fs._address.RouteI, nilnul.fs._address.vol.Comparer, nilnul.fs._address.route.Comparer>
			CoupleComp
			=>
		nilnul.obj_.Singleton<
			nilnul.obj.tuple_.bi.Comparer<nilnul.fs._address.VolI, nilnul.fs._address.RouteI,
				nilnul.fs._address.vol.Comparer,
				nilnul.fs._address.route.Comparer>
		>.Instance;

		public int Compare(AddressI x, AddressI y)
		{
			return CoupleComp.Compare(new Tuple<_address.VolI, _address.RouteI>(x.vol, x.route), new Tuple<_address.VolI, _address.RouteI>(y.vol, y.route));
		}


		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}
