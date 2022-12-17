namespace nilnul.fs.address.be_.shield
{
	public class Anto : nilnul.obj.be.Anto<nilnul.fs.AddressI, nilnul.fs.address.be_.Shield>
	{


#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<AddressI, Shield>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<AddressI, Shield>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}


	}
}
