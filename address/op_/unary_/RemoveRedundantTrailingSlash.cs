namespace nilnul.fs.address.op_.unary_
{
	/// <summary>
	///  "a:\", "a:\"
	///  "a:\b", "a:\b"
	///  "a:\b\", "a:\b"
	///  "a:\b\c", "a:\b\c"
	/// </summary>
	/// <remarks>
	/// alias:
	///		Lean
	///		Cutoff
	///		
	/// </remarks>
	public class Shrink : UnaryI
	{
		static public nilnul.fs.AddressI Op(nilnul.fs.AddressI address)
		{
			return nilnul.fs.AddressA.Ov(
				address.vol
				,
				nilnul.fs._address.route.op_.unary_.Shrink.Singleton.op(address.route)
			);
		}

		public AddressI op(AddressI par)
		{
			return Op(par);
			//throw new NotImplementedException();
		}

		static public Shrink Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Shrink>.Instance;
			}
		}

	}
}
