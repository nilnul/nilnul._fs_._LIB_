namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// one is the parent of the other or equal to the other. in other words, one nonstrictly contains the other.
	/// </summary>
	static public class _SupX
	{

		static public bool Re(route_.StemI x, route_.StemI y)
		{
			return stem._EqX.Eq(op_.binary_._SharedStubX.Co(x, y), x);
		}

	}

	public class Sup2 : ReI2
	{
		public bool re(StemI a, StemI b)
		{
			return _SupX.Re(a, b);
			//throw new NotImplementedException();
		}

		static public Sup2 Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Sup2>' is obsolete
				return nilnul._obj.Singleton<Sup2>.Instance;
#pragma warning restore CS0612 // 'Singleton<Sup2>' is obsolete
			}
		}


	}
}
