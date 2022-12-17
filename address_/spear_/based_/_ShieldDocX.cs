using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.spear_
{
	[Obsolete()]
	public class ShieldDoc : SpearI
	{
		private nilnul.fs.address_.ShieldI _shield;

		public nilnul.fs.address_.ShieldI shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address.DocI _doc;

		public nilnul.fs._address.DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public VolI vol => _shield.vol;

		public RouteI route => this.sprig;

		public _address.route_.SprigI1 sprig => new nilnul.fs._address.route_.sprig_.StemDoc1(_shield.stem, _doc);

		public ShieldDoc(nilnul.fs.address_.ShieldI container, nilnul.fs._address.DocI doc)
		{
			_shield = container;
			_doc = doc;
		}



		public ShieldDoc(SpearI element) :this(
			new nilnul.fs.address_.Shield(
				element.vol,
				new nilnul.fs._address.route_.Stem1(element.sprig.document.div)
			)
			 ,element.sprig.document.doc
		)
		{
			//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



		}

		public ShieldDoc(ShieldI container, string dst) : this(
			container, DocA.Parse(dst)
		)
		{
		}
		public ShieldDoc(string container, string dst) : this(
			address_.Shield.Parse(container), DocA.Parse(dst)
		)
		{
		}


		public override string ToString()
		{
			return $"{_shield}{_doc}";
		}

	}
}
