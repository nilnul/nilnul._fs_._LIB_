using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class Shield : ShieldA
	{
		private nilnul.fs._address.VolI _vol;

		public override nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			//set { _vol = value; }
		}

		private nilnul.fs._address.route_.StemI1 _stem;

		public override nilnul.fs._address.route_.StemI1 stem
		{
			get { return _stem; }
			//set { _stem = value; }
		}

		

		public Shield(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.StemI1 stem

		)
		{
			_vol = vol;
			_stem = stem;


		}

		public Shield(VolI vol1, IEnumerable<DirI1> enumerable)
			:this(vol1
				 , new nilnul.fs._address.route_.Stem1(enumerable)
				 )
		{
		}

		static public Shield Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return new Shield(
				_address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2))
				,
				nilnul.fs._address.route_.stem_._RouteX1.Fro(s.processed.Substring(2))
			);
		}

		static public Shield FroAddress(AddressI1 address) {
			return new Shield(
				address.vol
				,
				_address.route_.stem_._RouteX1.Fro(
					address.route
				)
			);
		}

		static public Shield FroAddress(string  address) {
			return FroAddress( nilnul.fs.Address1.Parse(address));
		}




		



		static public Shield Parse(string s)
		{

			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}

		
		public override string ToString()
		{
			return $"{_vol}{_stem}";
		}

		static public implicit operator Shield(DirectoryInfo dirInfo) {
			return Shield.Parse(dirInfo.ToString());
		}
	}
}
