using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.address_.spear_
{

	[Obsolete(nameof(based_.Child1))]
	public class ParentDoc : SpearI
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

		public ParentDoc(nilnul.fs.address_.ShieldI container, nilnul.fs._address.DocI doc)
		{
			_parent = container;
			_doc = doc;
		}
		public ParentDoc(nilnul.fs.address_.ShieldI container, nilnul.fs._address.Doc doc) : this(container, (DocI)doc)
		{

		}


		public ParentDoc(ShieldI container, string dst) : this(
			container, new Doc(dst)
		)
		{
		}

		public ParentDoc(DirectoryInfo container, string dst) : this(
			(nilnul.fs.address_.Shield)(container)
			,
			(dst)
		)
		{
		}

		public ParentDoc(ShieldI address, DstA dst) : this(address, new Doc(dst))
		{
		}
		public ParentDoc(string container, string dst) : this(
				address_.Shield.Parse(container), new Doc(dst)
			)
		{
		}

		public ParentDoc(ShieldI en, _address._route.division_._div._dir.DntI document)
			: this(
				 en
				 ,
				 _address._route.division_._div._dir.dnt._RegressionsX.ToOldDnt(document)
			)
		{
		}


		public ParentDoc(SpearI element) : this(
			new nilnul.fs.address_.Shield(
				element.vol,
				new nilnul.fs._address.route_.Stem(element.sprig.document.div)
			)
			 , element.sprig.document.doc
		)
		{
			//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



		}



		static public ParentDoc Of(SpearI element)
		{
			return new ParentDoc(
				new nilnul.fs.address_.Shield(
					element.vol,
					new nilnul.fs._address.route_.Stem(element.sprig.document.div)
				)
				 ,
				element.sprig.document.doc
			);



		}



		public ParentDoc(FileInfo video) : this((Spear)(video))
		{

		}

		public static ParentDoc Create_ofContainerAsAddress(string container, string dst)
		{
			return new ParentDoc(
				nilnul.fs.address_.Shield.FroAddress(container)
				,
				dst
			);
		}

		public static ParentDoc OfContainerAsAddress(string container, nilnul.fs._address.DocI dst)
		{
			return new ParentDoc(
				nilnul.fs.address_.Shield.FroAddress(container)
				,
				dst
			);
		}

		public static ParentDoc Parse(string x)
		{
			return new ParentDoc(
				Spear.Parse(x)
			);
		}

		public override string ToString()
		{
			return $"{_parent}{_doc}";
		}

	}
}
