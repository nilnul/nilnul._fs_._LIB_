using System;

namespace nilnul.txt.be_.fs_.address
{
	public class Exist : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return nilnul.txt.be_.fs_.Address.Singleton.be(obj) &&
				System.IO.File.Exists(obj);
			;

		}


		static private Lazy<Exist> _Lazy = new Lazy<Exist>();
		static public Exist Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


	}
}
