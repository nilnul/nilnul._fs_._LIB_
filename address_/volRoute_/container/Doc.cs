using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_.container
{
	static public class _DocX
	{
		static public nilnul.fs.address_.volRoute_.Element CreateElement(ContainerI container, string doc) {

			return new Element(
				container.vol,
				  _address.route_.deckedDocument_.DeckedDiv_Doc.CreateFroDeckedDivDoc(container.deckedDiv, doc
				 )
			);
		}
	}
}
