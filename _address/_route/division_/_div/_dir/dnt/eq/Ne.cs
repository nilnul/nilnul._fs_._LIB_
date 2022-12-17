namespace nilnul.fs._address.doc.eq
{
	public class Ne : nilnul.obj.eq.Ne<nilnul.fs._address.DocI, Eq>
	{

#pragma warning disable CS0108 // 'Ne.Singleton' hides inherited member 'Ne<DocI, Eq>.Singleton'. Use the new keyword if hiding was intended.
		static public Ne Singleton
#pragma warning restore CS0108 // 'Ne.Singleton' hides inherited member 'Ne<DocI, Eq>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Ne>.Instance;
			}
		}

	}
}
