using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;
using System.Collections.Generic;
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

		private nilnul.fs._address.route_.StemI _stem;

		public override nilnul.fs._address.route_.StemI stem
		{
			get { return _stem; }
			//set { _stem = value; }
		}

		public Shield(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.StemI stem
		)
		{
			_vol = vol;
			_stem = stem;


		}

		public Shield(VolI vol1, IEnumerable<DirI> enumerable)
			: this(vol1
				 , new nilnul.fs._address.route_.Stem(enumerable)
				 )
		{
		}

		public Shield(VolI vol1, SprigI sprig) //sprig 
			: this(
				 vol1
				 ,
				 nilnul.fs._address.route_.sprig.to_._StemX.Exe(sprig)
			)
		{

		}

		public Shield(VolI vol, _address.IDenotation denotation):this(
			vol,
			new _address.route_.Stem(denotation)
			//_address.DenotationX.Document(denotation)
		)
		{
				
		}

		static public Shield Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			var procesed = s.processed;

			if (procesed.Length<3)
			{
				throw new shield_.xpn_.ParseException($"{s}.length is lt 3;");
			}
			return new Shield(
				_address.Vol.Parse_fromTrimmed(procesed.Substring(0, 2))
				,
				nilnul.fs._address.route_.stem_._RouteX2.Fro(procesed.Substring(2))
			);
		}

		static public Shield _Parse_ofTrimmed(string s)
		{
			return new Shield(
				_address.Vol.Parse_fromTrimmed(s.Substring(0, 2))
				,
				nilnul.fs._address.route_.stem_._RouteX2.Fro(s.Substring(2))
			);
		}


		static public Shield Ov(AddressI address)
		{
			return new Shield(
				address.vol
				,
				_address.route_.stem_._RouteX2.Fro(
					address.route
				)
			);
		}
		static public Shield FroAddress(AddressI address)
		{
			return Ov(address);
		}



		static public Shield FroAddress(string address)
		{
			return FroAddress(nilnul.fs.AddressA.Parse(address));
		}

		static public Shield OvSpear(string address)
		{
			return OvSpear(
				nilnul.fs.address_.Spear.Parse(address)
			);
		}

		static public Shield OvSpear(nilnul.fs.address_.SpearI address)
		{

			return new Shield(
				address.vol
				,
				address.sprig
			);

		}




		static public implicit operator Shield(DirectoryInfo directoryInfo)
		{
			return shield_._AddressX1.Create(directoryInfo);
		}



		static public Shield Parse(string s)
		{
			try
			{
				return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));

			}
			catch (shield_.xpn_.ParseException x)
			{

				throw new shield_.xpn_.ParseException($"{s} after being trimmed is of length less than 3;",x);
			}


		}


		public override string ToString()
		{
			return $"{_vol}{_stem}";
		}

		//static public implicit operator Shield(DirectoryInfo dirInfo) {
		//	return Shield.Parse(dirInfo.FullName);
		//}
	}
}
