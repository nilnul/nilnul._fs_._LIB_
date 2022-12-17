namespace nilnul.fs.address_.shield.be_.root
{
	public class Anto : nilnul.fs.address_.shield.be.Anto<Root>, BeI1
	{
#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Root>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Root>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Anto>' is obsolete
				return nilnul._obj.Singleton<Anto>.Instance;
#pragma warning restore CS0612 // 'Singleton<Anto>' is obsolete
			}
		}
	}
}