namespace nilnul.txt.nulable.be_.fs_
{
	public class Address
		: nilnul.txt.nulable.BeI
	{
		public bool be(string obj)
		{
			if (obj == null)
			{
				return false;
			}
			return nilnul.txt.be_.fs_.Address.Singleton.be(obj);
			//throw new NotImplementedException();
		}

		public bool be_ifArgTrimmed(string s)
		{

			return be(s == null ? null : s.Trim());
		}



		static public Address Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Address>.Instance;
			}
		}

	}
}
