namespace nilnul.fs.address.be_.folderable
{
	public class Anto : address.be.Anto<
		address.be_.Folderable
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
