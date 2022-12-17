using nilnul.fs._address;
using nilnul.fs._address.route_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_
{
	public class BaseDivision :
		nilnul.fs.AddressI
	{
		private ShieldI _basic;

		public ShieldI basic
		{
			get { return _basic; }
			set { _basic = value; }
		}

		private nilnul.fs._address.DivisionI _descendent;

		public nilnul.fs._address.DivisionI descendent
		{
			get { return _descendent; }
			set { _descendent = value; }
		}

		public  VolI vol => _basic.vol;



		public RouteI route => 
			 nilnul.fs._address.route_.stem._DivisionX.Join(
				_basic.stem
				,
				_descendent

		);
			

		public BaseDivision(ShieldI container, nilnul.fs._address.DivisionI div)
		{
			_basic = container;
			_descendent = div;
		}


		public BaseDivision(VolI vol, IEnumerable<DirI> enumerable)
			: this(
				 new shield_.Vol1(vol), new nilnul.fs._address.Div(enumerable)
			 )
		{

		}



		public BaseDivision(ShieldI container) : this(container, new fs._address.Div())
		{
		}

		public BaseDivision(ShieldI container, string division) : this(container, DivisionA.Parse(division))
		{
		}

		public BaseDivision(ShieldI container, IEnumerable<Dnt> enumerable) : this(container, DivisionA.Ov(enumerable))
		{
		}

		public override string ToString()
		{
			return $"{_basic}{_descendent}";
		}


		static public BaseDivision Create_ofAddress( string base0, string division) {
			return new BaseDivision(
				nilnul.fs.address_.Shield.FroAddress(base0)
				,
				division
			);
		}

		static public BaseDivision OvAddress9Dnts( string base0, IEnumerable<string> division) {
			return new BaseDivision(
				nilnul.fs.address_.Shield.FroAddress(base0)
				,

				division.Select(d=> new Dnt(d))
			);
		}

		static public BaseDivision Ov_divisionOfDnts( nilnul.fs.address_.ShieldI base0, IEnumerable<string> division) {
			return new BaseDivision(
				(base0)
				,

				division.Select(d=> new Dnt(d))
			);
		}




	}
}
