using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container
{
	public static class _DstX
	{
		static public nilnul.fs.address_.Element CreateFroContainerDoc(
			nilnul.fs.address_.Container container
			,
			nilnul.fs._address_._path.Dst dst
			
		) {
			return new Element(
				new Address(
					container.ed.root
					,

					nilnul.fs._address_.path_.container.dst._AppendX._Append(
						container.ed.path 
						,dst
					)
				)
				
			);
		}

		public static nilnul.fs.address_.Element CreateFroContainerDoc(
			nilnul.fs.address_.Container container
			,
			nilnul.fs.address_._element_._path_.DocI doc
			
		
		
		) {

			return new Element(
				new Address(
					container.ed.root
					,

					nilnul.fs._address_.path_.container.dst._AppendX._Append(
						container.ed.path 
						,new _address_._path.Dst(doc.ToString())
					)
				)
				
			);
		}



		internal static Element CreateFroContainerDoc(Container ed, string doc)
		{
			return CreateFroContainerDoc(ed, new _address_._path.Dst(doc));
			throw new NotImplementedException();
		}
	}
}
