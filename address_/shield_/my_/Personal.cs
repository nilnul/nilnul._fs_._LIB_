using System;

namespace nilnul.fs.address_.shield_.my_
{
	/// <summary>
	/// "my documents"
	/// </summary>
	public class _DossiersX
	{

		public static string Address()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		}
		public static nilnul.fs.address_.Shield Shield()
		{
			return nilnul.fs.address_.Shield.FroAddress(Address());
		}



	}
}
