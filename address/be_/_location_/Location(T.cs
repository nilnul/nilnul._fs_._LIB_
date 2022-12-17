namespace nilnul.fs.address.be_._location_
{
	public class Address<T> : nilnul.obj.BeI1<T>

		where T : AddressI
	{
		public bool be(T obj)
		{
			var txt = obj.ToString();

			return System.IO.File.Exists(txt) || System.IO.Directory.Exists(txt);
		}


		static public Address<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Address<T>>.Instance;
			}
		}
	}


}
