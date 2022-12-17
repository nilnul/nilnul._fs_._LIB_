using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_
{
	/// <summary>
	/// given spear, get the main-newest
	/// </summary>
	static public class _NewestX
	{
		
		static public nilnul.fs.File File(nilnul.fs.address_.spear_.ParentDoc shield) {
			return  nilnul.fs.file_._BasedX.File(
				shield.parent
				,
				new _address.Doc(
				new nilnul.fs.folder.doc_.exted_.vered_.Newest(shield.parent).newest(shield.doc)
				)
			);

		}

	}
}
