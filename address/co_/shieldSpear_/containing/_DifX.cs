using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.address.co_.shieldSpear_.containing
{

	static public class _DifX
	{

		/// <summary>
		/// assume spear is contained in shield
		/// </summary>
		/// <param name="_base"></param>
		/// <param name="_document"></param>
		/// <returns></returns>
		static public _address.Document _Document_assumeHas(nilnul.fs.address_.ShieldI _base, nilnul.fs.address_.spear_.ParentDoc _document)
		{

			return new _address.Document(
				nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
					_base, _document.parent
				)
				, _document.doc
			);
		}

		[Obsolete(nameof(_Document_assumeHas))]
		static public _address.Document Document(nilnul.fs.address_.ShieldI _base, nilnul.fs.address_.spear_.ParentDoc _document)
		{

			return _Document_assumeHas(_base, _document);
		}

		static public _address.Document Document(nilnul.fs.address_.ShieldI _base, nilnul.fs.address_.SpearI _document)
		{

			return _Document_assumeHas(_base, new address_.spear_.ParentDoc(_document));
		}

		public static Document _Document_assumeHas(DirectoryInfo folder, FileInfo x)
		{
			return _Document_assumeHas(
				(nilnul.fs.address_.Shield)(folder),
				new address_.spear_.ParentDoc(
					x
				)
			);
			;
		}
	}
}
