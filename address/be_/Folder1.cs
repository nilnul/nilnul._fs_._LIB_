namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a folder. the address may be container  or tipped.
	/// </summary>
	public class Folder : BeA, BeI,BeI1
	{
		public override bool be(AddressI obj)
		{
			return System.IO.Directory.Exists(obj.ToString())   ///note: there may or may not be trailing slash
			;
		}

		public override bool be(string obj)
		{
			return System.IO.Directory.Exists(obj);
		}

		public bool be(AddressI1 obj)
		{
			return System.IO.Directory.Exists(obj.ToString());  ///note: there may or may not be trailing slash

		}


		static public Folder Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Folder>.Instance;
			}
		}
		static public Folder Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Folder>.Instance;
			}
		}




	}
}
