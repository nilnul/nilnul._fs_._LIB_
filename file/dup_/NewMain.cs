using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.dup_
{
	static public class _NewMainX
	{
		static public void Vod(nilnul.fs.FileI src, nilnul.fs._address.doc_._exted.MainI newMain, nilnul.fs.address_.shield_.Ensurable ensurable ) {
			System.IO.File.Copy(src.ToString(),

				new nilnul.fs.address_.spear_.ParentDoc(
					ensurable
					,
					new _address.doc_.MainExt(
						newMain
						,
						nilnul.fs.address_.spear._DocExtX.Ext(src.file.en)
					)
				).ToString()

				);
		}

		static public void Vod(string src, nilnul.fs._address.doc_._exted.MainI newMain, nilnul.fs.address_.shield_.Ensurable ensurable ) {
			Vod(new nilnul.fs.File(src), newMain, ensurable);
		}

		static public void Vod(string src, nilnul.fs._address.doc_._exted.Main newMain, nilnul.fs.address_.shield_.Ensurable ensurable ) {
			Vod(src, ( nilnul.fs._address.doc_._exted.MainI)( newMain) , ensurable);
		}

		static public void Vod(string src, string newMain, nilnul.fs.address_.shield_.Ensurable ensurable ) {
			Vod(src, new nilnul.fs._address.doc_._exted.Main( newMain) , ensurable);
		}

		static public void Vod(string src, string newMain, string ensurable ) {
			Vod(src, ( newMain) ,   address_.shield_.Ensurable.OfAddress(ensurable)  );
		}




	}
}
