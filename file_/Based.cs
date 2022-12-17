using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_
{
	static public class _BasedX
	{
		static public nilnul.fs.File File(nilnul.fs.FolderI basis, nilnul.fs._address.DocumentI document) {
			return new nilnul.fs.File(
				new nilnul.fs.address_.spear_.ParentDocument(basis.address.en, document)
			);
		}

		static public nilnul.fs.File File(nilnul.fs.FolderI basis, nilnul.fs._address.DocI document) {
			return new nilnul.fs.File(
				new nilnul.fs.address_.spear_.ParentDoc(basis.address.en, document)
			);
		}

		static public nilnul.fs.File File(nilnul.fs.address_.ShieldI basis, nilnul.fs._address.DocI document) {
			return File(
				new nilnul.fs.Folder(basis)
				,
				document
			);
		}

		static public nilnul.fs.File File(nilnul.fs.FolderI basis, nilnul.fs._address._route.division_._div._dir.DntI document) {
			return new nilnul.fs.File(
				new nilnul.fs.address_.spear_.ParentDoc(basis.address.en, document)
			);
		}

	}
}
