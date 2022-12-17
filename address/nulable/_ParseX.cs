using nilnul.exception_;

namespace nilnul.fs.address.nulable
{
	/// <summary>
	/// xpn as null
	/// </summary>
	static public class _ParseX
	{
		static public nilnul.fs.AddressI Parse(NotNull2<string> x)
		{
			try
			{
				return nilnul.fs.AddressA.Parse(x);
			}
			catch 
			{
				return null;
			}

		}

		static public nilnul.fs.AddressI Parse(string x)
		{
			if (x == null)
			{
				return null;
			}
			return Parse(new NotNull2<string>(x));

		}

		static public nilnul.fs.AddressI _Parse_assumeEmpty0address(string x)
		{
			if (x == string.Empty)
			{
				return null;
			}
			return nilnul.fs.AddressA.Parse(x);

		}

		static public nilnul.fs.AddressI _Parse_assumePaddedEmpty0address(string x)
		{
			
			return _Parse_assumeEmpty0address(x.Trim());

		}



	}
}
