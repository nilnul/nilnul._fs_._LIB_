using nilnul.fs._address;
using nilnul.fs._address._route.division_.div;
using System;

namespace nilnul.fs.address_.spear_.based_
{
	/// <summary>
	/// 
	/// </summary>
	/// todo: rename this to BasedDenotation
	///
	public class ParentDocument : SpearA1
	{
		private nilnul.fs.address_.ShieldI1 _shield;
		public nilnul.fs.address_.ShieldI1 shield
		{
			get { return _shield; }
			set { _shield = value; }
		}

		private nilnul.fs._address._route.division_.div.DntedI _document;
		public nilnul.fs._address._route.division_.div.DntedI document
		{
			get { return _document; }
			set { _document = value; }
		}

		public override VolI vol => _shield.vol;

		public override _address.route_.SprigI1 sprig => new nilnul.fs._address.route_.sprig_.StemDenotation(_shield.stem, _document);

		public ParentDocument(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address._route.division_.div.DntedI document)
		{
			_shield = container;
			_document = document;
		}

		public ParentDocument(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address._route.division_.div.Dnted document)
		{
			_shield = container;
			_document = document;
		}
		public ParentDocument(AddressI1 ee, DntedI key):this(
			 nilnul.fs.address_.Shield1.Ov(ee),key

		)
		{
		}

		public ParentDocument(SpearI1 element) : this(
			new nilnul.fs.address_.Shield1(
				element.vol,
				new nilnul.fs._address.route_.Stem1(element.sprig.denotation.div)
			)
			 , element.sprig.denotation
		)
		{
		}

		public ParentDocument(ShieldI1 container, string document) : this(
			container, Dnted.Parse(document)
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
			address_.Shield1.Parse(container), Dnted.Parse(dst)
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
				address_.Shield1.FroAddress(container), Dnted.Parse(dst)
			);
		}

		static public ParentDocument Create_documentOvDnts(
			nilnul.fs.address_.ShieldI1 container
			,
			string dst
			,
			params string[] dnts
		)
		{
			return new ParentDocument(
				container
				,
				
				 _address._route.division_.div.Dnted.OvDnts(dst, dnts)
				
			);
		}




	}
}
