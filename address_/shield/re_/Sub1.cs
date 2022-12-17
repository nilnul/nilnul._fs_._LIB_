namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class Sub : ReI
	{


		public bool re(ShieldI a, ShieldI b)
		{
			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route_.stem.re_.Sub.Singleton.re(
					a.stem, b.stem
				);
			}

			return false;
			//throw new NotImplementedException();
		}


		static public Sub Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sub>.Instance;
			}
		}

	}
}
