namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	static public class _DisjointX
	{
		static public bool Re(nilnul.fs.address_.ShieldI a, nilnul.fs.address_.ShieldI b)
		{

			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route_.stem.re_._DisjointX2.Re(
					a.stem, b.stem
				);
			}
			return true;
		}
		static public bool Re_bySub(nilnul.fs.address_.ShieldI a, nilnul.fs.address_.ShieldI b)
		{
			return sub.Complement1.Singleton.re(a, b) && sub.Complement1.Singleton.re(b,a);
			;
		}



	}
}
