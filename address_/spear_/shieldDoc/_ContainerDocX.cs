using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.element_
{
	[Obsolete()]
	static class _ContainerDocX
	{
		static public nilnul.fs.address_.ContainerI1 Container(this ElementI1 element)
		{
			return new nilnul.fs.address_.Container1(
				element.vol
				,
				new _address.route_.Stem(element.sprig.document.div)
			);
		}

	}

	public class ContainerDoc:ElementI1
	{
		private nilnul.fs.address_.ContainerI1 _container;

		public nilnul.fs.address_.ContainerI1 container
		{
			get { return _container; }
			set { _container = value; }
		}

		private nilnul.fs._address.DocI _doc;

		public nilnul.fs._address.DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public VolI vol => _container.vol;

		public RouteI route => this.sprig;

		public _address.route_.SprigI sprig => nilnul.fs._address.route_.sprig_.StemDoc.FroStemDoc(_container.stem, _doc);

		public ContainerDoc(nilnul.fs.address_.ContainerI1 container, nilnul.fs._address.DocI doc  )
		{
			_container = container;
			_doc = doc;
		}



		public ContainerDoc(ElementI1 element)
		{
			var sprig = new nilnul.fs._address.route_.sprig_.StemDoc(element.sprig);


			_container = new nilnul.fs.address_.Container1(element.vol, new nilnul.fs._address.route_.stem_.DeckDiv(sprig.document.div) );

			_doc = sprig.document.doc;
		}

		public ContainerDoc(ContainerI1 container, Dst dst):this(
			container,DocA.Parse(dst)
		)
		{
		}

		public override string ToString()
		{
			return $"{_container}{_doc}";
		}

	}
}
