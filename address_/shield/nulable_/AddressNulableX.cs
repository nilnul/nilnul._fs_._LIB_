namespace nilnul.fs.address_.shield.nulable_
{
	static public class _AddressNulableX
	{
		static public nilnul.fs.address_.ShieldI Parse(nilnul.fs.AddressI x)
		{
			return x == null ? null : nilnul.fs.address_.shield_._AddressX1.Create(x);
		}

	

		static public nilnul.fs.address_.ShieldI Parse(nilnul.NotNull2<string> x)
		{
			return Parse(nilnul.fs.address.nulable._ParseX.Parse(x));
		}

		static public nilnul.fs.address_.ShieldI Parse(string x)
		{
			return x == null ? null : Parse(new nilnul.NotNull2<string>(x));
		}
	}
}
