namespace nilnul.txt.be_.fs_.endWithDeck
{
	public class Anto
		: nilnul.obj.be.Anto<string, EndWithDirSep>
		, nilnul.txt.BeI

	{


#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<string, EndWithDirSep>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<string, EndWithDirSep>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
