using nilnul.exception_;

namespace nilnul.fs.address.nulable.parse_
{
	/// <summary>
	/// xpn as null
	/// </summary>
	static public class _EmptyAsNulX
	{

		

		static public nilnul.fs.AddressI _Parse_assumeEmpty0address(string x)
		{
			if (x == string.Empty)
			{
				return null;
			}
			return nilnul.fs.AddressA.Parse(x);

		}
		static public nilnul.fs.AddressI Parse(NotNull2<string> x)
		{
			return _Parse_assumeEmpty0address(x);

		}

		static public nilnul.fs.AddressI _Parse_assumePaddedEmpty0address(string x)
		{
			
			return _Parse_assumeEmpty0address(x.Trim());

		}



	}
}
