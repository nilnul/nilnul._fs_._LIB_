using nilnul.fs._address.doc_.exted_;

namespace nilnul.fs._address.doc_.dotted0No
{
	static public class _ExtX
	{
		static public doc_._exted.ExtI Ext(Dotted dotted)
		{
			return new doc_._exted.ext_.OvAftDot(dotted.extOvAftDot.ToString());
		}

		public static doc_._exted.ExtI Ext(DottedOrNoI dottedOrNo)
		{
			switch (dottedOrNo)
			{
				case NoDot nodot:
					return new doc_._exted.Ext();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
				case Dotted dotted:
					return Ext(dotted);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		public static doc_._exted.ExtI Ext(DocI obj)
		{
			switch (obj)
			{
				case DottedOrNoI dottedOrNo:
					return Ext(dottedOrNo);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
				default:
					return Ext(DottedOrNoIX.Parse(obj.ToString()));
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public doc_._exted.ExtI _Ext(string _doc)
		{
			return Ext(
				new nilnul.fs._address.Doc(_doc)
			);
		}
	}
}
