using nilnul.fs._address;
using nilnul.fs._address.route_;
using System.Collections.Generic;

namespace nilnul.fs.address_.based_
{
	public class Child :
		nilnul.fs.AddressI1
	{
		private ShieldI1 _shield;

		public ShieldI1 shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address._route.division_._div.DstI _dst;

		public nilnul.fs._address._route.division_._div.DstI descendent
		{
			get { return _dst; }
			set { _dst = value; }
		}

		public  VolI vol => _shield.vol;

		public _address.RouteI1 route => 
			 new nilnul.fs._address.route_.based_.Child(
				_shield.stem
				,
				_dst

		);
			

		public Child(ShieldI1 container, nilnul.fs._address._route.division_._div.DstI dst)
		{
			_shield = container;
			_dst = dst;
		}


		public Child(VolI vol, _address._route.division_._div. DirI dir)
			: this(
				 Shield1.Of(vol), (dir)
			 )
		{

		}



		public Child(ShieldI1 container, string dst) : this(container, _address._route.division_._div. DstA.Parse(dst))
		{
		}

		public override string ToString()
		{
			return $"{_shield}{_dst}";
		}


		static public Child BaseOfAddress( string base0, string division) {
			return new Child(
				nilnul.fs.address_.Shield1.FroAddress(base0)
				,
				division
			);
		}



	}
}
