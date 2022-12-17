namespace nilnul.txt.op_.unary_.fs_
{
	public class StripEndSep : nilnul.txt.op_.UnaryI
	{


		public string op(string par)
		{
			if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(par))
			{
				return par.Substring(0, par.Length-1);
			}
			return par;

		}

		static public StripEndSep Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<StripEndSep>.Instance;
			}
		}

	}
}
