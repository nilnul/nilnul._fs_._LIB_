namespace nilnul.txt.op_.unary_.fs_
{
	public class StripBeginSep : nilnul.txt.op_.UnaryI
	{


		public string op(string par)
		{
			if (nilnul.txt.be_.fs_.BeginWithSep.Singleton.be(par))
			{
				return par.Substring(1);
			}
			return par;

		}

		static public StripBeginSep Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<StripBeginSep>.Instance;
			}
		}

	}
}
