namespace nilnul.fs.address_.spear.be_
{
	static public class _EnsurableX
	{
		static public bool _Be(string address)
		{
			return !System.IO.Directory.Exists(address);
		}


	}

	/// <summary>
	/// </summary>
	public class Ensurable
		: nilnul.fs.address_.spear.BeI
	{
		public bool be(SpearI obj)
		{
			return be(obj.ToString());
			//throw new NotImplementedException();
		}

		public bool be(string address)
		{
			return !System.IO.Directory.Exists(address);
		}



		static public Ensurable Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Ensurable>' is obsolete
				return nilnul._obj.Singleton<Ensurable>.Instance;
#pragma warning restore CS0612 // 'Singleton<Ensurable>' is obsolete
			}
		}




	}
}
