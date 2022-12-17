using nilnul.fs._address._dst;
using System;

namespace nilnul.fs._address.denote_.exted
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

		public static doc_._exted.Ext Ext(Denote obj)
		{
			return new doc_._exted.Ext( _Txt(obj) );


		}
		public static doc_._exted.Ext Ext(DocI obj)
		{
			return new doc_._exted.Ext( Txt(obj) );

			//switch (obj)
			//{
			//	case DottedOrNoI dottedOrNo:
			//		return Ext(dottedOrNo);
			//		break;
			//	default:
			//		return Ext(DottedOrNoIX.Parse(obj.ToString()));
			//		break;
			//}
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
