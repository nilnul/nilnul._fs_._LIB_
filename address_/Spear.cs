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
	public class Spear :SpearA // SpearI
	{
		private nilnul.fs._address.VolI _vol;

		public override nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			//set { _vol = value; }
		}

		private nilnul.fs._address.route_.SprigI1 _sprig;

		public override nilnul.fs._address.route_.SprigI1 sprig
		{
			get { return _sprig; }
			//set { _stem = value; }
		}

		

		public Spear(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.SprigI1 sprig

		)
		{
			_vol = vol;
			_sprig = sprig;


		}

		

		static public Spear Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return Parse(s.processed);
		}

		


		



		static public Spear Parse(string s)
		{

			return new Spear(
				_address.Vol.Parse_fromTrimmed(s.Substring(0, 2))
				,
				nilnul.fs._address.route_.Sprig2.Parse(s.Substring(2))
			);


		}

		
		public override string ToString()
		{
			return $"{_vol}{_sprig}";
		}

		static public implicit operator Spear(FileInfo dirInfo) {
			return Spear.Parse(dirInfo.ToString());
		}
	}
}
