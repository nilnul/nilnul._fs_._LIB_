using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	using nilnul.fs._address;
using System.IO;


namespace nilnul.fs.address_.spear_.based_.child_
{
	public class AsExted1
	 : SpearI1
		{
			private nilnul.fs.address_.ShieldI1 _parent;

			public nilnul.fs.address_.ShieldI1 parent
			{
				get => _parent;
				set => _parent = value;
			}

			private nilnul.fs._address._route.division_._div._dir.dnt_.Exted _doc;

			public nilnul.fs._address._route.division_._div._dir.dnt_.Exted doc
			{
				get => _doc;
				set => _doc = value;
			}

			public VolI vol => _parent.vol;

			public RouteI1 route => this.sprig;

			public _address.route_.SprigI1 sprig => new nilnul.fs._address.route_.sprig_.StemDoc1(_parent.stem, _doc);

			public AsExted1(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address._route.division_._div._dir.dnt_.Exted doc)
			{
				_parent = container;
				_doc = doc;
			}
			public AsExted1(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address._route.division_._div._dir.DntI doc) : this(container,  _address._route.division_._div._dir.dnt_.Exted.Ov( doc ))
			{

			}

			public AsExted1(nilnul.fs.address_.ShieldI1 container, nilnul.fs._address._route.division_._div._dir.Dnt doc) : this(container,  _address._route.division_._div._dir.dnt_.Exted.Ov( doc ))
			{

			}


			public AsExted1(ShieldI1 container, string dst) : this(
				container, new _address._route.division_._div._dir.Dnt(dst)
			)
			{
			}

			public AsExted1(DirectoryInfo container, string dst) : this(
				(nilnul.fs.address_.Shield1)(container)
				,
				(dst)
			)
			{
			}

			public AsExted1(ShieldI1 address, _address._route.division_._div. DstA dst) : this(address, _address._route.division_._div._dir. Dnt.Ov(dst))
			{
			}
			public AsExted1(string container, string dst) : this(
					address_.Shield1.FroAddress(container), (dst)
				)
			{
			}


			public AsExted1(SpearI1 element) : this(
				new nilnul.fs.address_.Shield1(
					element.vol,
					new nilnul.fs._address.route_.Stem1(element.sprig.denotation.div)
				)
				 , element.sprig.denotation.dnt.ToString()
			)
			{
				//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



			}




			public AsExted1(FileInfo video) : this((Spear1)(video))
			{

			}


			public static AsExted1 Create_ofContainerAsAddress(string container, string dst)
			{
				return new AsExted1(
					nilnul.fs.address_.Shield1.FroAddress(container)
					,
					dst
				);
			}

			public static AsExted1 OfContainerAsAddress(string container, nilnul.fs._address._route.division_._div._dir.DntI  dst)
			{
				return new AsExted1(
					nilnul.fs.address_.Shield1.FroAddress(container)
					,
					dst.ToString()
				);
			}

			public static AsExted1 OfContainerAsAddress(string container, nilnul.fs._address._route.division_._div._dir.Dnt dst)
			{
				return new AsExted1(
					nilnul.fs.address_.Shield1.FroAddress(container)
					,
					dst.ToString()
				);
			}

			public static AsExted1 Parse(string x)
			{
				return new AsExted1(
					Spear1.Parse(x)
				);
			}

			public override string ToString()
			{
				return $"{_parent}{_doc}";
			}

		}
	}
