namespace nilnul.fs.address_.spear.be_
{
	public class Folder
		: nilnul.fs.address_.spear.BeI
	{
		public bool be(SpearI obj)
		{
			return System.IO.Directory.Exists(obj.ToString());
		}

		static public Folder Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Folder>.Instance;
			}
		}




	}
}
