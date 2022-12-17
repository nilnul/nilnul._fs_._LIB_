using System;

namespace nilnul.txt.be_.fs_.address.exist
{
	public class Anto : nilnul.txt.be.Anto<Exist>
	{

		static private Lazy<Anto> _Lazy = new Lazy<Anto>();
		static public Anto Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
