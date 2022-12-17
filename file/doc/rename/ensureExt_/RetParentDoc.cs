using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.doc.rename.ensureExt_
{
	static public class _RetParentDocX
	{
		static public nilnul.fs.address_.spear_.ParentDoc ParentDoc(nilnul.fs.address_.spear_.ParentDoc _file, nilnul.fs._address.doc_._exted.ExtI newExt) {

			//var oldExt = nilnul.fs._address.doc_.exted._ExtX.Ext(_file.doc);

			if (! nilnul.fs._address.doc_._exted.ext.Eq.Singleton.Equals(nilnul.fs._address.doc_.exted._ExtX.Ext(_file.doc), newExt))
			{
				var r = _file.doc.ToString() + newExt.ToString();
				fs.file._RenameX.Rename(
					_file,
					r
					
				);

				return new nilnul.fs.address_.spear_.ParentDoc(_file.parent, r);
			}
			return _file;
		}


		static public nilnul.fs.address_.spear_.ParentDoc ParentDoc(nilnul.fs.FileI file, nilnul.fs._address.doc_._exted.ExtI newName) {

			return ParentDoc(
				new nilnul.fs.address_.spear_.ParentDoc(file.file.en)
				,
				newName
			);
		}
		static public nilnul.fs.address_.spear_.ParentDoc ParentDoc(string file, string newName) {

			return ParentDoc(
				new nilnul.fs.File(file)
				,
				new nilnul.fs._address.doc_._exted.Ext(
					newName
				)
			);
		}
		static public nilnul.fs.address_.spear_.ParentDoc ParentDoc(FileInfo file, string newName) {

			return ParentDoc(
				new nilnul.fs.File(file)
				,
				new nilnul.fs._address.doc_._exted.Ext(
					newName
				)
			);
		}

		public static nilnul.fs.address_.spear_.ParentDoc ParentDoc(string newNamed, nilnul.fs._address.doc_._exted.ExtI doc)
		{
			return ParentDoc( new nilnul.fs.File(newNamed),doc);
		}
	}
}
