using System;

namespace nilnul.fs._address.doc_.exted
{
	[Obsolete()]
	static public class _ExtX
	{
		public static doc_._exted.ExtI Ext(DocI obj)
		{
			return nilnul.fs._address.doc_.MainExt.Ov(obj).ext;
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


		static public doc_._exted.ExtI _Ext(string _doc)
		{
			return Ext(
				new nilnul.fs._address.Doc(_doc)
			);
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
