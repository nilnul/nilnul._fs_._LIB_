using System;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	static public class _DocX
	{
		static public _address.Document Join(DivI div, _address.DocI doc)
		{
			return new Document(
				div, doc

			);

		}

		static public _address.Document Join(DivI div, DstI doc)
		{
			return Join(div, new _address.Doc(doc));

			//throw new NotImplementedException();
		}



	}
}
