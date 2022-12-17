namespace nilnul.fs.address_.shield.be_.newable
{
	public class Anto : nilnul.fs.address_.shield.be.Anto<Newable>
		,
		nilnul.fs.address_.shield.BeI1
	{

#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Folder>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Folder>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
