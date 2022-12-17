using nilnul.exception_;
using System.IO;

namespace nilnul.fs.address_
{
	//extern alias bit;
	public class Spear1 : SpearA1 // SpearI
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



		public Spear1(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.SprigI1 sprig

		)
		{
			_vol = vol;
			_sprig = sprig;


		}

		public Spear1(string s) : this(
				_address.Vol.Parse_fromTrimmed(s.Substring(0, 2))
				,
				nilnul.fs._address.route_.Sprig1.Parse(s.Substring(2))
			)
		{


		}

		public Spear1(FileInfo fileInfo) : this(fileInfo.FullName)
		{

		}



#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public Spear1 Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		{
			return Parse(s.processed);
		}








		static public Spear1 Parse(string s)
		{
			new /*bit::*/nilnul.bit.vow_.True1<ParseException>(new ParseException("spear shall not be less than 2 chars long")).vow(s.Length >= 2);

			return new Spear1(
				_address.Vol.Parse_fromTrimmed(s.Substring(0, 2))
				,
				nilnul.fs._address.route_.Sprig1.Parse(s.Substring(2))
			);


		}


		public override string ToString()
		{
			return $"{_vol}{_sprig}";
		}

		static public implicit operator Spear1(FileInfo dirInfo)
		{
			return Spear1.Parse(dirInfo.FullName);
		}

	
	}
}
