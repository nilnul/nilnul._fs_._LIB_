using System;

namespace nilnul.fs.address_.shield_
{
	/// <summary>
	/// </summary>
	public class _MyX
	{

		public static string Address()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		}

		public static nilnul.fs.address_.Shield Shield()
		{
			return nilnul.fs.address_.Shield.FroAddress(Address());
		}

	}
}
