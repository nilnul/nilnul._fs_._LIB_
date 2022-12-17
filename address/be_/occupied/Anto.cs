namespace nilnul.fs.address.be_.occupied
{
	public class Anto : address.be.anto_.BeDefault<
		address.be_.Occupied
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
