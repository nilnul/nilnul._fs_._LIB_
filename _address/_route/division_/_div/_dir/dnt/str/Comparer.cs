namespace nilnul.fs._address._dst.denote.str
{
	public class Comparer :
		nilnul.obj.str.Comp<Denote, denote.comp_.Cn>
	//,
	//IComparer<IEnumerable<_dst.Denote>>
	{


#pragma warning disable CS0108 // 'Comparer.Singleton' hides inherited member 'Comp<Denote, Cn>.Singleton'. Use the new keyword if hiding was intended.
		static public Comparer Singleton
#pragma warning restore CS0108 // 'Comparer.Singleton' hides inherited member 'Comp<Denote, Cn>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}
