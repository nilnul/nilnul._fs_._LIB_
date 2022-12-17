using System;
using System.IO;

namespace nilnul.fs._address.doc
{
	[Obsolete]
	static public class _MainX
	{
		static public string Txt(nilnul.fs._address.DocI doc)
		{
#pragma warning disable CS0612 // '_MainX.Txt(string)' is obsolete
			return Txt(doc.denote);
#pragma warning restore CS0612 // '_MainX.Txt(string)' is obsolete
		}


		static public _address.doc_._exted.Main Main(nilnul.fs._address.DocI doc)
		{
			return new doc_._exted.Main(Txt(doc));
		}

		static public string __Txt(string doc)
		{
			var lastIndex = doc.LastIndexOf(".");
			return lastIndex == -1 ? doc : doc.Substring(0, lastIndex);
		}

		[Obsolete()]
		static public string Txt(string doc)
		{

			return __Txt(doc);
		}

		public static string Txt(nilnul.fs.address_.SpearI spear)
		{
			return Txt(
				nilnul.fs.address_.spear._DocX.Doc(spear)
			);
			throw new NotImplementedException();
		}
		public static string Txt(nilnul.fs.address_.Spear info)
		{
			return Txt(
				info as nilnul.fs.address_.SpearI
			);
			throw new NotImplementedException();
		}


		public static string Txt(FileInfo info)
		{
			return Txt(
				(address_.Spear)info
			);
			throw new NotImplementedException();
		}

	}
}
