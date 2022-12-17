namespace nilnul.character_.cha.set_.fs_
{
	public class DirSep : nilnul.character_.cha.Set1
	{
		public DirSep() : base(nilnul.character_.chas_.fs_.DirSep.Chars)
		{
		}

		static public DirSep Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DirSep>.Instance;
			}
		}

	}
}