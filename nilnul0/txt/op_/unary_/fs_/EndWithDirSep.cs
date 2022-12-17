namespace nilnul.txt.op_.unary_.fs_
{
	public class EnsureEndWithDirSep : nilnul.txt.op_.UnaryI
	{


		public string op(string par)
		{
			if (nilnul.txt.be_.fs_.endWithDeck.Anto.Singleton.be(par))
			{
				return $"{par}{ nilnul.fs._address._route_._SeparatorX.AsChar}";
			}
			return par;

		}

		static public EnsureEndWithDirSep Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EnsureEndWithDirSep>.Instance;
			}
		}

	}
}
