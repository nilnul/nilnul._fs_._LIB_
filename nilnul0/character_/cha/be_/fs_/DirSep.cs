namespace nilnul.character_.cha.be_.fs_
{
	public class DirSep
		: nilnul.character_.cha.BeI
	{
		public bool be(char obj)
		{
			return cha.set_.fs_.DirSep.Singleton.contain(obj);
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
