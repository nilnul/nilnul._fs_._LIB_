using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file._address_
{
	public class Doc
	{
		/// <summary>
		/// nullable
		/// </summary>
		/// <returns></returns>
		static public nilnul.fs.file._address_.doc_._dotted_.Ext getExtNullable(
			nilnul.fs._address.DocNameI docName
		) {
			return new doc_._dotted_.Ext( docName.ext);
		}
	}
}
