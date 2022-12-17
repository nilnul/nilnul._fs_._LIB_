namespace nilnul.fs.address.be_
{
	public class Location<T> : nilnul.obj.BeI1<T>

		where T : AddressI1
	{
		public bool be(T obj)
		{
			var txt = obj.ToString();

			return System.IO.File.Exists(txt) || System.IO.Directory.Exists(txt);
		}



		static public Location Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Location>.Instance;
			}
		}
		static public Location Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Location>.Instance;
			}
		}


	}


}
