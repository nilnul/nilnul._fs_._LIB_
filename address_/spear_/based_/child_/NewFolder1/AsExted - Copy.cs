using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	using nilnul.fs._address;
using System.IO;


namespace nilnul.fs.address_.spear_.based_.child_
{
	[Obsolete()]
	public class AsExted
	 : SpearI
		{
			private nilnul.fs.address_.ShieldI _parent;

			public nilnul.fs.address_.ShieldI parent
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

			public RouteI route => this.sprig;

			public _address.route_.SprigI sprig => new nilnul.fs._address.route_.sprig_.StemDoc(_parent.stem, _doc);

			public AsExted(nilnul.fs.address_.ShieldI container, nilnul.fs._address._route.division_._div._dir.dnt_.Exted doc)
			{
				_parent = container;
				_doc = doc;
			}
			public AsExted(nilnul.fs.address_.ShieldI container, nilnul.fs._address._route.division_._div._dir.DntI doc) : this(container,  _address._route.division_._div._dir.dnt_.Exted.Ov( doc ))
			{

			}

			public AsExted(nilnul.fs.address_.ShieldI container, nilnul.fs._address._route.division_._div._dir.Dnt doc) : this(container,  _address._route.division_._div._dir.dnt_.Exted.Ov( doc ))
			{

			}


			public AsExted(ShieldI container, string dst) : this(
				container, new _address._route.division_._div._dir.Dnt(dst)
			)
			{
			}

			public AsExted(DirectoryInfo container, string dst) : this(
				(nilnul.fs.address_.Shield)(container)
				,
				(dst)
			)
			{
			}

			public AsExted(ShieldI address, _address._route.division_._div. DstA dst) : this(address, _address._route.division_._div._dir. Dnt.Ov(dst))
			{
			}
			public AsExted(string container, string dst) : this(
					address_.Shield.FroAddress(container), (dst)
				)
			{
			}


			public AsExted(SpearI element) : this(
				new nilnul.fs.address_.Shield(
					element.vol,
					new nilnul.fs._address.route_.Stem(element.sprig.document.div)
				)
				 , element.sprig.document.doc.ToString()
			)
			{
				//var sprig = new nilnul.fs._address.route_.sprig_.StemDoc1(element.sprig);



			}




			public AsExted(FileInfo video) : this((Spear)(video))
			{

			}


			public static AsExted Create_ofContainerAsAddress(string container, string dst)
			{
				return new AsExted(
					nilnul.fs.address_.Shield.FroAddress(container)
					,
					dst
				);
			}

			public static AsExted OfContainerAsAddress(string container, nilnul.fs._address.DocI dst)
			{
				return new AsExted(
					nilnul.fs.address_.Shield.FroAddress(container)
					,
					dst.ToString()
				);
			}

			public static AsExted OfContainerAsAddress(string container, nilnul.fs._address._route.division_._div._dir.Dnt dst)
			{
				return new AsExted(
					nilnul.fs.address_.Shield.FroAddress(container)
					,
					dst.ToString()
				);
			}

			public static AsExted Parse(string x)
			{
				return new AsExted(
					Spear.Parse(x)
				);
			}

			public override string ToString()
			{
				return $"{_parent}{_doc}";
			}

		}
	}
