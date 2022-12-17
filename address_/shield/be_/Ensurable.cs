namespace nilnul.fs.address_.shield.be_
{
	/// <summary>
	///  unoccupied by file. a folder, or unoccupied
	/// </summary>
	public class Ensurable : BeI1
	{
		public bool be(ShieldI obj)
		{
			if (be_.Root.Singleton.be(obj))
			{
				return true;
			}

			return nilnul.fs.address_.shield_.nonRt.be_.Ensurable.Singleton._be(obj);
			//throw new NotImplementedException();
		}

		public bool be(string _shield)
		{
			return be(Shield.Parse(_shield));
		}

		public bool be_ofAddress(string _shield)
		{
			return be(Shield.FroAddress(_shield));
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
