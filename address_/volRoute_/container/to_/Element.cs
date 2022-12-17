using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_.container.to_
{
	public class Element
	{
		static public volRoute_.ElementI JoinDoc(
			volRoute_.ContainerI container
			,
			nilnul.fs._address.DocNameI doc
		) {
			return new volRoute_.Element(
				container.vol
				,
				new _address.route_.deckedDocument_.DeckedDiv_Doc(
					container.deckedDiv
					,
					doc
				)
			);
		}

		static public volRoute_.Element JoinDocument(
			volRoute_.ContainerI container
			,
			nilnul.fs._address.document_.DivDoc document
		) {
			return new volRoute_.Element(
				container.vol
				,
				 _address.route_.deckedDocument_.OfDocument.CreateFroDeckedDivAndDocument(


					container.deckedDiv
					,
					document
				)
			);
		}



		public static volRoute_.ElementI JoinDoc(ContainerI dataRoute, string v)
		{
			return JoinDoc(
				dataRoute,
				 nilnul.fs._address.DocNameA.Parse(v)
			);

			throw new NotImplementedException();
		}
	}
}
