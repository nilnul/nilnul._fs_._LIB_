namespace nilnul.fs.address.be_.location
{
	public class Anto : address.be.Anto<
		address.be_.Location
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
