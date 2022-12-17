namespace nilnul.fs.address.nulable.comp_
{
	public class Cn : nilnul.txt.CompI
	{
		public int Compare(string x, string y)
		{
			var xAddress = nilnul.fs.address.nulable._ParseX.Parse(x);
			var yAddress = nilnul.fs.address.nulable._ParseX.Parse(y);
			if (xAddress == null)
			{
				if (yAddress == null)
				{
					return nilnul.txt.comparer_.upperUp_.Cn.Singleton.Compare(x, y);
				}
				return -1;

			}
			if (yAddress == null)
			{
				return 1;
			}

			return nilnul.fs.address.Comparer.Singleton.Compare(xAddress, yAddress);
		}

		static public Cn Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cn>.Instance;
			}
		}

	}
}
