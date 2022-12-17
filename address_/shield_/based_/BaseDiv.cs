using nilnul.fs._address;
using nilnul.fs._address.route_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield_.based_
{
	public class BasedDiv :
		ShieldA1
	//,
	//ShieldI
	{
		private ShieldI1 _basic;

		public ShieldI1 basic
		{
			get { return _basic; }
			set { _basic = value; }
		}

		private nilnul.fs._address._route.division_.DivI _descendent;

		public nilnul.fs._address._route.division_.DivI descendent
		{
			get { return _descendent; }
			set { _descendent = value; }
		}

		public override VolI vol => _basic.vol;


		public override StemI1 stem => new nilnul.fs._address.route_.stem_.based_.BasedDiv(
				_basic.stem.div
				,
				_descendent

		);

		public BasedDiv(ShieldI1 container, nilnul.fs._address._route.division_.DivI div)
		{
			_basic = container;
			_descendent = div;
		}


		public BasedDiv(VolI vol, IEnumerable<_address._route.division_._div.DirI> enumerable)
			: this(
				 new Shield1(vol), new nilnul.fs._address._route.division_.Div(enumerable)
			 )
		{

		}



		public BasedDiv(ShieldI1 container) : this(container, new fs._address._route.division_.Div())
		{
		}

		public BasedDiv(ShieldI1 en, _address._route.division_.div.DntedI key) : this(
			en
			,
			_address._route.division_.div_.directory.op_.of_._DocumentX.Exe(key)
		)
		{
		}

		public BasedDiv(ShieldI1 en, IEnumerable<_address._route.division_._div. Dir> enumerable):this(en, new nilnul.fs._address._route.division_.Div(enumerable))
		{
		}

		public BasedDiv(AddressI1 en, IEnumerable<_address._route.division_._div. DirI> enumerable):this( nilnul.fs.address_.Shield1.Ov(en), new nilnul.fs._address._route.division_.Div(enumerable))
		{
		}

		public override string ToString()
		{
			return $"{_basic}{_descendent}";
		}

		static public BasedDiv Of_divOfDnts(nilnul.fs.AddressI1 basis, IEnumerable<string > dnts) {

			return new BasedDiv(basis, dnts.Select(d=> _address._route.division_._div.Dir.OfDnt(d)));

		}
		static public BasedDiv Of_baseOfAddress_divOfDnts(string basis, IEnumerable<string > dnts) {

			return Of_divOfDnts(nilnul.fs.AddressA1.Parse(basis) ,dnts);

		}

		static public BasedDiv Of_divOfDnts(nilnul.fs.AddressI1 basis, params string[] dnts) {

			return Of_divOfDnts(basis, dnts as IEnumerable<string> );

		}

		static public BasedDiv Of_baseOfAddress_divOfDnts(string basis, params string[] dnts) {
			return Of_divOfDnts(nilnul.fs.AddressA1.Parse(basis) ,dnts);
		}




	}
}
