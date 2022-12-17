using System;

namespace nilnul.fs.address_.shield_
{
	/// <summary>
	/// </summary>
	public class _PersonalX
	{

		public static string Address()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		}

	}
}
