using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;
using nilnul.fs._address.route_;
using nilnul.fs._address.route_.deckedDocument_;

namespace nilnul.fs.address_.volRoute_
{
	[Obsolete()]

	public class Element:ElementI
	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs._address.route_.deckedDocument_.OfDocument _deckedDocument;

		public nilnul.fs._address.route_.deckedDocument_.OfDocument deckedDocument
		{
			get { return _deckedDocument; }
			set { _deckedDocument = value; }
		}



		public Container container {
			get {
				return new Container(
					vol,

					new _address.route_.DeckedDiv(
						_deckedDocument.document.div
					)
				);
			}
		}

		public RouteI route
		{
			get
			{
				return _deckedDocument;
				throw new NotImplementedException();
			}
		}

		public Element(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.deckedDocument_.OfDocument deckedDocument

		)
		{
			_vol = vol;
			_deckedDocument = deckedDocument;


		}

		public Element(VolI vol, DeckedDocument deckedDocument1)
		{
			this.vol = vol;

			this._deckedDocument = deckedDocument1;
		}

		public Element(Vol vol, DeckedDiv_Doc deckedDiv_Doc)
			:this(vol,  (DeckedDocument)deckedDiv_Doc)
		{

		}

		static public Element Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{

			return new Element(
				 _address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2)) as VolI
					
				, nilnul.fs._address.route_.deckedDocument_.OfDocument.Parse(s.processed.Substring(2))
				
			);


		}



		static public Element Parse(string s)
		{

			return Parse( new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}

		static public implicit operator FileInfo(Element element) {
			return new FileInfo(element.ToString());
		}

		static public implicit operator Element(FileInfo fileInfo) {
			return Parse(fileInfo.FullName);
		}
		public override string ToString()
		{
			return $"{_vol}{_deckedDocument}";
		}
	}
}
