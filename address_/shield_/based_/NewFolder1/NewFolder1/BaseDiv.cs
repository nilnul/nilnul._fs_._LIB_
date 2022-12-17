using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	public class BaseDiv :
		ShieldA
	//,
	//ShieldI
	{
		private ShieldI _basic;

		public ShieldI basic
		{
			get { return _basic; }
			set { _basic = value; }
		}

		private nilnul.fs._address.DivI _descendent;

		public nilnul.fs._address.DivI descendent
		{
			get { return _descendent; }
			set { _descendent = value; }
		}

		public override VolI vol => _basic.vol;


		public override StemI stem => new nilnul.fs._address.route_.stem_.ParentDiv1(
				_basic.stem.div
				,
				_descendent

		);

		public BaseDiv(ShieldI container, nilnul.fs._address.DivI div)
		{
			_basic = container;
			_descendent = div;
		}


		public BaseDiv(VolI vol, IEnumerable<DirI> enumerable)
			: this(
				 new shield_.Vol1(vol), new nilnul.fs._address.Div(enumerable)
			 )
		{

		}



		public BaseDiv(ShieldI container) : this(container, new fs._address.Div())
		{
		}

		public BaseDiv(ShieldI en, DocumentI key) : this(
			en
			,
			_address.directory_._DocumentX.Exe(key)
		)
		{
		}

		public BaseDiv(ShieldI en, IEnumerable<Dir> enumerable):this(en, new nilnul.fs._address.Div(enumerable))
		{
		}

		public BaseDiv(AddressI en, IEnumerable<DirI> enumerable):this( nilnul.fs.address_.Shield.Ov(en), new nilnul.fs._address.Div(enumerable))
		{
		}

		public override string ToString()
		{
			return $"{_basic}{_descendent}";
		}

		static public BaseDiv Ov_divOfDnts(nilnul.fs.AddressI basis, IEnumerable<string > dnts) {

			return new BaseDiv(basis, dnts.Select(d=>  Dir.OvDenote(d)));

		}

		static public BaseDiv Create_divOfDnts(nilnul.fs.AddressI basis, params string[] dnts) {

			return Ov_divOfDnts(basis, dnts as IEnumerable<string> );

		}




	}
}
