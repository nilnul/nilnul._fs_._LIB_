namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// </summary>
	/// 
	public class Sub : ReI2
	{
		/// <summary>
		/// x is the child of y, or x==y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool re(StemI x, StemI y)
		{
			return stem._EqX.Eq(op_.binary_._SharedStubX.Co(x, y), y);
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
