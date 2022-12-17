using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class Element : nilnul.fs.address.be_.tipped.vow.Ed
		,nilnul.fs.AddressI
	{
		public Element(Address val) : base(val)
		{
		}

		public Element(string s):this(new Address(s))
		{

		}

		public nilnul.fs.address_.Container container { get {
				return new Container(
					new Address(
						ed.root
						,
						new _address_.Path(
							ed.path.stem
						)
					)
				);
		} }

		public static implicit operator Element(FileInfo v)
		{
			return new Element(
				v.FullName
			);
			throw new NotImplementedException();
		}

		public static Element Create(nilnul.fs.Folder container, nilnul.fs.address_._element_._path_.DocI doc) {
			return new Element(
				nilnul.fs.address_.container._DstX.CreateFroContainerDoc(container.ed, doc)
			);
		}
	}
}
