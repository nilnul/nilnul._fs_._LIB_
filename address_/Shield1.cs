using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;
using System.Collections.Generic;
using System.IO;

namespace nilnul.fs.address_
{
	public class Shield1 : ShieldA1
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

		public Shield1(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.StemI1 stem
		)
		{
			_vol = vol;
			_stem = stem;


		}

		public Shield1(VolI vol1, IEnumerable<_address._route.division_._div.DirI> enumerable)
			: this(vol1
				 , new nilnul.fs._address.route_.Stem1(enumerable)
				 )
		{
		}

		public Shield1(VolI vol1, SprigI1 sprig) //sprig 
			: this(
				 vol1
				 ,
				 nilnul.fs._address.route_.sprig.op_.to_._StemX.Exe(sprig)
			)
		{

		}

		public static Shield1 Of(VolI vol)
		{

			return new Shield1(vol, new Stem1());
		}

		public Shield1(VolI vol, _address._route.division_.div.IDnted denotation):this(
			vol,
			new _address.route_.Stem1(denotation)
			//_address.DenotationX.Document(denotation)
		)
		{
				
		}

		public Shield1(VolI vol1):this(vol1, new _address.route_.Stem1())
		{
		}

		static public Shield1 Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return new Shield1(
				_address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2))
				,
				nilnul.fs._address.route_.stem.op_.of_._RouteX2.Fro(s.processed.Substring(2))
			);
		}

		static public Shield1 _Parse_ofTrimmed(string s)
		{
			return new Shield1(
				_address.Vol.Parse_fromTrimmed(s.Substring(0, 2))
				,
				nilnul.fs._address.route_.stem.op_.of_._RouteX2.Fro(s.Substring(2))
			);
		}


		static public Shield1 Ov(AddressI1 address)
		{
			return new Shield1(
				address.vol
				,
				_address.route_.stem.op_.of_._RouteX2.Fro(
					address.route
				)
			);
		}
		static public Shield1 FroAddress(AddressI1 address)
		{
			return Ov(address);
		}



		static public Shield1 FroAddress(string address)
		{
			return FroAddress(nilnul.fs.AddressA1.Parse(address));
		}

		static public Shield1 OvSpear(string address)
		{
			return OvSpear(
				nilnul.fs.address_.Spear1.Parse(address)
			);
		}

		static public Shield1 OvSpear(nilnul.fs.address_.SpearI1 address)
		{

			return new Shield1(
				address.vol
				,
				address.sprig
			);

		}




		static public implicit operator Shield1(DirectoryInfo directoryInfo)
		{
			return shield.op_.of_._AddressX.Create(directoryInfo);
		}



		static public Shield1 Parse(string s)
		{

#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'


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
