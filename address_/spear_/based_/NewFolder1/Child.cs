using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.address_.spear_.based_
{

	public class Child : SpearI
	{
		private nilnul.fs.address_.ShieldI _parent;

		public nilnul.fs.address_.ShieldI parent
		{
			get => _parent;
			set => _parent = value;
		}

		private nilnul.fs._address.DocI _doc;

		public nilnul.fs._address.DocI doc
		{
			get => _doc;
			set => _doc = value;
		}

		public VolI vol => _parent.vol;

		public RouteI route => this.sprig;

		public _address.route_.SprigI sprig => new nilnul.fs._address.route_.sprig_.StemDoc(_parent.stem, _doc);

		public Child(nilnul.fs.address_.ShieldI container, nilnul.fs._address.DocI doc)
		{
			_parent = container;
			_doc = doc;
		}
		public Child(nilnul.fs.address_.ShieldI container, nilnul.fs._address.Doc doc) : this(container, (DocI)doc)
		{

		}


		public Child(ShieldI container, string dst) : this(
			container, new Doc(dst)
		)
		{
		}

		public Child(DirectoryInfo container, string dst) : this(
			(nilnul.fs.address_.Shield)(container)
			,
			(dst)
		)
		{
		}

		public Child(ShieldI address, DstA dst) : this(address, new Doc(dst))
		{
		}
		public Child(string container, string dst) : this(
				address_.Shield.Parse(container), new Doc(dst)
			)
		{
		}

		public Child(ShieldI en, _address._route.division_._div._dir.DntI document)
			: this(
				 en
				 ,
				 _address._route.division_._div._dir.dnt._RegressionsX.ToOldDnt(document)
			)
		{
		}

		public Child(ShieldI en, _address._route.division_._div._dir.Dnt document)
			: this(
				 en
				 ,
				 _address._route.division_._div._dir.dnt._RegressionsX.ToOldDnt(document)
			)
		{
		}

		public Child(SpearI element) : this(
			new nilnul.fs.address_.Shield(
				element.vol,
				new nilnul.fs._address.route_.Stem(element.sprig.document.div)
			)
			 , element.sprig.document.doc
		)
		{
			//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



		}




		public Child(FileInfo video) : this((Spear)(video))
		{

		}

		public static Child Create_ofContainerAsAddress(string container, string dst)
		{
			return new Child(
				nilnul.fs.address_.Shield.FroAddress(container)
				,
				dst
			);
		}

		public static Child OfContainerAsAddress(string container, nilnul.fs._address.DocI dst)
		{
			return new Child(
				nilnul.fs.address_.Shield.FroAddress(container)
				,
				dst
			);
		}

		public static Child Parse(string x)
		{
			return new Child(
				Spear.Parse(x)
			);
		}

		public override string ToString()
		{
			return $"{_parent}{_doc}";
		}

	}
}
