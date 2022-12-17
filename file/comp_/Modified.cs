namespace nilnul.fs.file.comp_
{
	public class Modified : CompI
	{
		public int Compare(FileI x, FileI y)
		{
			return
				nilnul.time_.datetime.Comp.Singleton.Compare(
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTimeUtc
						,
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTimeUtc
				)
			;


			//throw new NotImplementedException();
		}


		static public Modified Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Modified>' is obsolete
				return nilnul._obj.Singleton<Modified>.Instance;
#pragma warning restore CS0612 // 'Singleton<Modified>' is obsolete
			}
		}

	}
}
