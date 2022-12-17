namespace nilnul.fs.address.be_.file
{
	public class Anto : address.be.Anto<
		address.be_.File
	>
	{

		static public Anto Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
