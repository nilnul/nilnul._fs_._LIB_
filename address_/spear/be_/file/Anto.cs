namespace nilnul.fs.address_.spear.be_.file
{
	public class Anto
		: nilnul.fs.address_.spear.be.Anto<File>
	{
		//public bool be(SpearI1 obj)
		//{
		//	return !System.IO.File.Exists(obj.ToString());
		//	throw new NotImplementedException();
		//}



#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<File>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<File>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}




	}
}
