using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;
using System.Collections.Generic;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class BaseDst :
		nilnul.fs.AddressI
	{
		private ShieldI _shield;

		public ShieldI shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address.DstI _dst;

		public nilnul.fs._address.DstI descendent
		{
			get { return _dst; }
			set { _dst = value; }
		}

		public  VolI vol => _shield.vol;

		public RouteI route => 
			 new nilnul.fs._address.route_.BaseDst(
				_shield.stem
				,
				_dst

		);
			

		public BaseDst(ShieldI container, nilnul.fs._address.DstI dst)
		{
			_shield = container;
			_dst = dst;
		}


		public BaseDst(VolI vol, DirI dir)
			: this(
				 new shield_.Vol1(vol), (dir)
			 )
		{

		}



		public BaseDst(ShieldI container, string dst) : this(container, DstA.Parse(dst))
		{
		}

		public override string ToString()
		{
			return $"{_shield}{_dst}";
		}


		static public BaseDst OvAddress( string base0, string division) {
			return new BaseDst(
				nilnul.fs.address_.Shield.FroAddress(base0)
				,
				division
			);
		}



	}
}
