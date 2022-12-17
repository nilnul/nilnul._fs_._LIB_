using System;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	static public class _DivisionX
	{
		static public DivI _Fro(DivisionI division)
		{
			switch (division)
			{
				case DivI div:
					return div;
				case DocumentI document:
					return div.op_.binary_.Concat.Singleton.op(document.div, document.doc);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public DivI Fro(string division)
		{
			return _Fro(
				nilnul.fs._address.DivisionA.Parse(division)
			);
		}
		[Obsolete("defending against obsolete types")]
		static public DivI Fro(DivisionI division)
		{
			return Fro(division.ToString());
		}
	}
}
