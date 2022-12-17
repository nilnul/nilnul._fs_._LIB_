using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.shield.doc
{
	
	public class ShieldDoc1 : SpearI1
	{
		private nilnul.fs.address_.ShieldI1 _shield;

		public nilnul.fs.address_.ShieldI1 shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address.DocI1 _doc;

		public nilnul.fs._address.DocI1 doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public VolI vol => _shield.vol;

		public RouteI route => this.sprig;

		public _address.route_.SprigI2 sprig => new nilnul.fs._address.route_.sprig_.StemDoc2(_shield.stem, _doc);

		public ShieldDoc1(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address.DocI1 doc)
		{
			_shield = container;
			_doc = doc;
		}



		public ShieldDoc1(SpearI1 element) :this(
			new nilnul.fs.address_.Shield1(
				element.vol,
				new nilnul.fs._address.route_.Stem2(element.sprig.document.div)
			)
			 ,element.sprig.document.doc
		)
		{
			//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



		}

		public ShieldDoc1(ShieldI1 container, string dst) : this(
			container, DocA1.Parse(dst)
		)
		{
		}
		public ShieldDoc1(string container, string dst) : this(
			address_.Shield1.Parse(container), DocA1.Parse(dst)
		)
		{
		}

		static public ShieldDoc1 Parse(string x) {
			return new ShieldDoc1(
				Spear1.Parse(x)
			);
		}

		public override string ToString()
		{
			return $"{_shield}{_doc}";
		}

	}
}
