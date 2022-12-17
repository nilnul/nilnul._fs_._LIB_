using System;

namespace nilnul.txt.be_.fs_
{
	public class Folder : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return /*nilnul.txt.be_.fs_.Address.Singleton.be(obj) &&*/
				System.IO.Directory.Exists(obj);
			;

		}



		static public Folder Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Folder>.Instance;
			}
		}



	}
}
