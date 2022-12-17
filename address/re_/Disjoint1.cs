namespace nilnul.fs.address.re_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	static public class _DisjointX
	{
		static public bool Re(nilnul.fs.AddressI a, nilnul.fs.AddressI b)
		{
			return address_.shield.re_._DisjointX.Re(
				nilnul.fs.address_.Shield.FroAddress(a)
				,
				nilnul.fs.address_.Shield.FroAddress(b)
			);
		}
	}
}