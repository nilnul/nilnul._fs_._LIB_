using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document.op_.unary_
{
	static public class _ChangeMainX
	{
		static public _address.Document Document( _address.DivI div, _address.DocI doc, _address.doc_._exted.MainI newMain) {

			return new Document(
				div
				,
				_address.denote_.exted.op_.unary_._ChangeMainX.ChangeMain(doc,newMain)
			);
		}

		static public _address.Document Document( _address.DocumentI document, _address.doc_._exted.MainI newMain) {

			return Document(
				document.div
				,
				document.doc
				,
				newMain
			);
		}

	}
}
