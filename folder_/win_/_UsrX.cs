using System;

namespace nilnul.fs.folder_.win_
{
	static public class _UsrX
	{
		static public string MyDocuments
		{
			get
			{
				return System.Environment.GetFolderPath(
					 Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create
				);
			}
		}

		static public string Personal
		{
			get
			{
				return System.Environment.GetFolderPath(
					 Environment.SpecialFolder.Personal, Environment.SpecialFolderOption.Create
				);
			}
		}


	}
}
