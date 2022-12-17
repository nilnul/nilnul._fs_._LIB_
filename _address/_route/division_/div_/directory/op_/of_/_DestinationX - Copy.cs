using System;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	static public class _DestinationX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentOrDirectory"></param>
		/// <returns></returns>
		static public DivI _Fro(DestinationI documentOrDirectory)
		{
			switch (documentOrDirectory)
			{
				case DirectoryI directory:
					return new Div(directory);
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
				nilnul.fs._address.DestinationA.Parse(division)
			);
		}
		[Obsolete("defending against obsolete types")]
		static public DivI Fro(DestinationI division)
		{
			return Fro(division.ToString());
		}
	}
}
