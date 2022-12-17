namespace nilnul.fs.address.eq
{
#pragma warning disable CS0618 // 'Address' is obsolete: 'this shall be abstract'
	public class Ne : nilnul.obj.eq.Ne<nilnul.fs.AddressI, Eq>
#pragma warning restore CS0618 // 'Address' is obsolete: 'this shall be abstract'
	{

#pragma warning disable CS0108 // 'Neq.Singleton' hides inherited member 'Neq<Address, Eq>.Singleton'. Use the new keyword if hiding was intended.
#pragma warning disable CS0618 // 'SingletonByDefault<Neq>' is obsolete: 'Singleton'
#pragma warning restore CS0618 // 'SingletonByDefault<Neq>' is obsolete: 'Singleton'
#pragma warning restore CS0108 // 'Neq.Singleton' hides inherited member 'Neq<Address, Eq>.Singleton'. Use the new keyword if hiding was intended.

		public bool ne(string x, string y)
		{
#pragma warning disable CS0618 // 'Address' is obsolete: 'this shall be abstract'
#pragma warning disable CS0618 // 'Address' is obsolete: 'this shall be abstract'
			return ne(nilnul.fs.Address.Parse(x), nilnul.fs.Address.Parse(y));
#pragma warning restore CS0618 // 'Address' is obsolete: 'this shall be abstract'
#pragma warning restore CS0618 // 'Address' is obsolete: 'this shall be abstract'
		}


		static public Ne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ne>.Instance;
			}
		}

	}
}
