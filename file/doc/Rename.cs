using nilnul.fs._address;
using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file
{
	static public class _RenameX
	{
		static public void _Rename(nilnul.fs.address_.spear_.ParentDoc _file, nilnul.fs._address.DocI newName) {

			System.IO.File.Move(
				_file.ToString(),
				new nilnul.fs.address_.spear_.ParentDoc(_file.parent, newName).ToString()
			);
		}
		static public void Rename(nilnul.fs.FileI file, nilnul.fs._address.DocI newName) {

			_Rename(
				new nilnul.fs.address_.spear_.ParentDoc(file.file.en)
				,
				newName
			);
		}

		public static void Rename(ParentDoc file, string v)
		{
			_Rename(file, new nilnul.fs._address.Doc(v));
		}

		static public void Rename(string file, string newName) {

			Rename(
				new nilnul.fs.File(file)
				,
				new nilnul.fs._address.Doc(
					newName
				)
			);
		}

		public  static void Rename(string newNamed, DocI doc)
		{
			Rename( new nilnul.fs.File(newNamed),doc);
		}
	}
}
