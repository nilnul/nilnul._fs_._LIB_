using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;
using nilnul.fs._address.route_;
using nilnul.fs.address_._shield_;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class Container1 : ContainerI1
	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs._address.route_.StemI _stem;

		public nilnul.fs._address.route_.StemI stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		public RouteI route
		{
			get
			{
				return _stem;
			}
		}


		public Container1(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.StemI stem

		)
		{
			_vol = vol;
			_stem = stem;


		}

		static public Container1 Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return new Container1(
				_address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2))
				,
				nilnul.fs._address.route_.Stem.OfRoute(s.processed.Substring(2))
			);
		}

		static public Container1 FroAddress(AddressI1 address) {
			return new Container1(
				address.vol
				,
				_address.route_.Stem.FroRoute(
					address.route
				)
			);
		}

		static public Container1 FroAddress(string  address) {
			return FroAddress( nilnul.fs.Address1.Parse(address));
		}




		static public Container1 FroContainerDiv(
				Container1 container
				,
				nilnul.fs._address.DivI div

			)
		{
			return new Container1(
				container.vol
				,
				new _address.route_.Stem(

					nilnul.fs._address.div.co_.Concat.Singleton.op(
						container.stem.div
						,
						div

					)
				)
			);
		}



		static public Container1 Parse(string s)
		{

			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}

		
		public override string ToString()
		{
			return $"{_vol}{_stem}";
		}

		static public implicit operator Container1(DirectoryInfo dirInfo) {
			return Container1.Parse(dirInfo.ToString());
		}
	}
}
