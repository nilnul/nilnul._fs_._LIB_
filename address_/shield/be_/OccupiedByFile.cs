namespace nilnul.fs.address_.shield.be_
{
	public class OccupiedByFile : BeI1
	{
		public bool be(ShieldI obj)
		{
			if (be_.Root.Singleton.be(obj))
			{
				return false;
			}

			return nilnul.fs.address_.shield_.nonRt.be_.OccupiedByFile.Singleton._be(obj);
			//throw new NotImplementedException();
		}

		public bool be(string _shield)
		{
			return be(Shield.Parse(_shield));
		}

		public bool be_ofAddress(string address)
		{
			return be(Shield.FroAddress(address));
		}

		static public OccupiedByFile Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<OccupiedByFile>' is obsolete
				return nilnul._obj.Singleton<OccupiedByFile>.Instance;
#pragma warning restore CS0612 // 'Singleton<OccupiedByFile>' is obsolete
			}
		}

	}
}
