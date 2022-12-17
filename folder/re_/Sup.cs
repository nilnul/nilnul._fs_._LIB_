namespace nilnul.fs.folder.re_
{
	public class Sup : ReI
	{
		public bool re(FolderI a, FolderI b)
		{
			return nilnul.fs.address_.shield.re_.Sup.Singleton.re(a.address.en, b.address.en);
			//throw new NotImplementedException();
		}


		static public Sup Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sup>.Instance;
			}
		}

	}
}
