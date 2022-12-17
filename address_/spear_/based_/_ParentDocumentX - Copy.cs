using nilnul.fs._address;
using System;

namespace nilnul.fs.address_.spear_.based_
{
	/// <summary>
	/// 
	/// </summary>
	/// todo: rename this to BasedDenotation
	public class ParentDocument : SpearA
	{
		private nilnul.fs.address_.ShieldI _shield;
		public nilnul.fs.address_.ShieldI shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address.DocumentI _document;
		public nilnul.fs._address.DocumentI document
		{
			get { return _document; }
			set { _document = value; }
		}

		public override VolI vol => _shield.vol;

		public override _address.route_.SprigI sprig => new nilnul.fs._address.route_.sprig_.StemDocument(_shield.stem, _document);

		public ParentDocument(nilnul.fs.address_.ShieldI container, nilnul.fs._address.DocumentI document)
		{
			_shield = container;
			_document = document;
		}

		public ParentDocument(nilnul.fs.address_.ShieldI container, nilnul.fs._address.Document document)
		{
			_shield = container;
			_document = document;
		}

		public ParentDocument(SpearI element) : this(
			new nilnul.fs.address_.Shield(
				element.vol,
				new nilnul.fs._address.route_.Stem(element.sprig.document.div)
			)
			 , element.sprig.document
		)
		{
		}

		public ParentDocument(ShieldI container, string document) : this(
			container, Document.Parse(document)
		)
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="container">is in format of shield (end at separator), not in the format of spear(not end at separator)</param>
		/// <param name="dst"></param>

		[Obsolete()]
		
		public ParentDocument(string container, string dst) : this(
			address_.Shield.Parse(container), Document.Parse(dst)
		)
		{
		}

		public override string ToString()
		{
			return $"{_shield}{_document}";
		}

		static public ParentDocument Create_allowParentAddress(string container, string dst)
		{
			return new ParentDocument(
				address_.Shield.FroAddress(container), Document.Parse(dst)
			);
		}

		

	}
}
