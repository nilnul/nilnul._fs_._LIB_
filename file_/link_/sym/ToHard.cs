using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.link_.sym
{
	static public class _ToHardX
	{
		static public void Vod(this nilnul.fs.file_.link_.Sym sym) {

			

			var fileAsParentDoc = new nilnul.fs.address_.spear_.ParentDoc(sym.ee.file.en);

			var mainExt =  nilnul.fs._address.doc_.MainExt.Ov(fileAsParentDoc.doc);

			var newNamed = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(
					fileAsParentDoc.parent
				).address(
					mainExt.main + "__toHard"
					,
					mainExt.ext
				);

			///create hard linke
			///
			nilnul.fs.file_.link_.hard._CreateX.Create(
				newNamed
				,
				sym.target
			);

			nilnul.fs.file.del_._RecyclableX.Del(sym);

			nilnul.fs.file._RenameX.Rename(newNamed, fileAsParentDoc.doc);


		}

		public static void Vod(string v)
		{
			Vod(new nilnul.fs.file_.link_.Sym(v) );
		}
	}
}
