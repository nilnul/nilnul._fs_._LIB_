using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.doc.rename
{
	static public class _EnsureExtX
	{

		static public void Vod(nilnul.fs.address_.spear_.ParentDoc _file, nilnul.fs._address.doc_._exted.ExtI newExt) {

			var oldExt = nilnul.fs._address.doc_.exted._ExtX.Ext(_file.doc);

			if (! nilnul.fs._address.doc_._exted.ext.Eq.Singleton.Equals(oldExt,newExt))
			{
				fs.file._RenameX.Rename(
					_file,

					_file.doc.ToString() + newExt.ToString()
				);
			}
		}

		static public void Vod(nilnul.fs.FileI file, nilnul.fs._address.doc_._exted.ExtI newName) {

			Vod(
				new nilnul.fs.address_.spear_.ParentDoc(file.file.en)
				,
				newName
			);
		}
		static public void Vod(string file, string newName) {

			Vod(
				new nilnul.fs.File(file)
				,
				new nilnul.fs._address.doc_._exted.Ext(
					newName
				)
			);
		}
		static public void Vod(FileInfo file, string newName) {

			Vod(
				new nilnul.fs.File(file)
				,
				new nilnul.fs._address.doc_._exted.Ext(
					newName
				)
			);
		}

		public  static void Vod(string newNamed, nilnul.fs._address.doc_._exted.ExtI doc)
		{
			Vod( new nilnul.fs.File(newNamed),doc);
		}
	}
}
