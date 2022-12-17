using nilnul.fs._address;
using nilnul.fs._address._route.division_.div;
using System;
using System.IO;

namespace nilnul.fs.address_.spear_.based_
{

	public class Child1 : SpearI1
	{
		private nilnul.fs.address_.ShieldI1 _parent;

		public nilnul.fs.address_.ShieldI1 parent
		{
			get => _parent;
			set => _parent = value;
		}

		private nilnul.fs._address._route.division_._div._dir.DntI  _dnt;

		[Obsolete(nameof(dnt))]
		public nilnul.fs._address._route.division_._div._dir.DntI doc
		{
			get => _dnt;
			set => _dnt = value;
		}

		public nilnul.fs._address._route.division_._div._dir.DntI dnt
		{
			get => _dnt;
			set => _dnt = value;
		}

		public VolI vol => _parent.vol;
		public _address.route_.SprigI1 sprig => new nilnul.fs._address.route_.sprig_.StemDoc1(_parent.stem, _dnt);

		public RouteI1 route => this.sprig;


		public Child1(
			nilnul.fs.address_.ShieldI1 container
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc
		)
		{
			_parent = container;
			_dnt = doc;
		}

		public Child1(
			nilnul.fs.address_.ShieldI1 container
			,
			nilnul.fs._address._route.division_._div._dir.Dnt doc
		)
		:
		this(
			container
			,
			(nilnul.fs._address._route.division_._div._dir.DntI)doc
		)
		{

		}


		public Child1(ShieldI1 container, string dst)
			:
		this(
			container
				,
			new nilnul.fs._address._route.division_._div._dir.Dnt(dst)
		)
		{
		}

		public Child1(DirectoryInfo container, string dst) : this(
			(nilnul.fs.address_.Shield1)(container)
			,
			(dst)
		)
		{
		}

		public Child1(ShieldI1 address, _address._route.division_._div.DstA dst) : this(address, new _address._route.division_._div._dir.Dnt(dst))
		{
		}
		public Child1(string container, string dst) : this(
				address_.Shield1.Parse(container), new  _address._route.division_._div._dir.Dnt(dst)
			)
		{
		}

		public Child1(SpearI1 element) : this(
			new nilnul.fs.address_.Shield1(
				element.vol,
				new nilnul.fs._address.route_.Stem1(element.sprig.denotation.div)
			)
			 , element.sprig.denotation.dnt
		)
		{
		}

		public Child1(FileInfo video) : this((Spear1)(video))
		{
		}

		public Child1(AddressI1 ee, DntedI key)
		{
		}

		public static Child1 Create_ofContainerAsAddress(string container, string dst)
		{
			return new Child1(
				nilnul.fs.address_.Shield1.FroAddress(container)
				,
				dst
			);
		}

		public static Child1 OfContainerAsAddress(string container, nilnul.fs._address._route.division_._div._dir.DntI dst)
		{
			return new Child1(
				nilnul.fs.address_.Shield1.FroAddress(container)
				,
				dst
			);
		}

		public static Child1 Parse(string x)
		{
			return new Child1(
				Spear1.Parse(x)
			);
		}

		public override string ToString()
		{
			return $"{_parent}{_dnt}";
		}

	}
}
