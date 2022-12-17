using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.address_
{
	/// <summary>
	/// vol and sprig
	/// </summary>
	/// 
	[Obsolete()]
	public class Element1 : ElementI1
	{
		private nilnul.fs._address.VolI _vol;
		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs._address.route_.SprigI _sprig;
		public nilnul.fs._address.route_.SprigI sprig
		{
			get { return _sprig; }
			set { _sprig = value; }
		}

		

		public RouteI route
		{
			get
			{
				return _sprig;
			}
		}

		public Element1(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.SprigI sprig
		)
		{
			_vol = vol;
			_sprig = sprig;
		}

		static public Element1 Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return new Element1(
				_address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2))
				,
				nilnul.fs._address.route_.Sprig1.Parse(s.processed.Substring(2))
			);
		}

		

		//static public Element1 FroAddress(AddressI1 address) {
		//	return new Element1(
		//		address.vol
		//		,
		//		_address.route_.Sprig.FroRoute(
		//			address.route
		//		)
		//	);
		//}

		//static public Element1 FroAddress(string  address) {
		//	return FroAddress( nilnul.fs.Address1.Parse(address));
		//}




		//static public Container1 FroContainerDiv(
		//		Container1 container
		//		,
		//		nilnul.fs._address.DivisionI div

		//	)
		//{
		//	return new Container1(
		//		container.vol
		//		,
		//		new _address.route_.DeckedDocument(

		//			nilnul.fs._address.div.combine_.Concat.Singleton.eval(
		//				container.stem.div
		//				,
		//				div

		//			)
		//		)
		//	);
		//}



		static public Element1 Parse(string s)
		{

			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}

		
		public override string ToString()
		{
			return $"{_vol}{_sprig}";
		}

		static public implicit operator Element1(FileInfo dirInfo) {
			return Parse(dirInfo.FullName);
		}
	}
}
