using nilnul.fs._address._dst;
using System;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted
{
	static public class _ExtX
	{

		static public string _Txt(string _doc)
		{
			var lastIndex = _doc.LastIndexOf(".");
			if (lastIndex<0)
			{
				return "";
			}
			return _doc.Substring(lastIndex);
			
		}
		public static string Txt(DocI obj)
		{
			return (_Txt(obj.ToString()));
		}
		public static string Txt(DntI obj)
		{
			return (_Txt(obj.ToString()));
		}

		 static _exted.ExtI ExtI(DntI obj)
		{
			return dnt_.Exted.Ov(obj).ext;
		}



		public static doc_._exted.Ext Ext(Denote obj)
		{
			return new doc_._exted.Ext( _Txt(obj) );

		}
		public static doc_._exted.Ext Ext(DocI obj)
		{
			return new doc_._exted.Ext( Txt(obj) );

		}
		public static dnt_._exted.Ext Ext(DntI obj)
		{
			return new dnt_._exted.Ext( Txt(obj) );

		}



		//public static doc_._exted.ExtI Ext(DottedOrNoI dottedOrNo)
		//{

		//	switch (dottedOrNo)
		//	{
		//		case NoDot nodot:
		//			return new doc_._exted.Ext();
		//			break;
		//		case doc_.exted_.Dotted dotted:
		//			return dotted.extOvAftDot;
		//			break;
		//		default:
		//			throw new UnexpectedTypeException();
		//			break;
		//	}
		//}
	}
}
