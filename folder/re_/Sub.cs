namespace nilnul.fs.folder.re_
{
	public class Sub : ReI
	{
		public bool re(FolderI a, FolderI b)
		{
			return nilnul.fs.address_.shield.re_.Sub.Singleton.re(a.address.en, b.address.en);
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
